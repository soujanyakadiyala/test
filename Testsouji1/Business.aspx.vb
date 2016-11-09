Imports System.Data

Partial Class Business
    Inherits System.Web.UI.Page
    Protected Overloads Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            Dim dt As DataTable

            If (Not Page.IsPostBack) Then
                dt = Hydrator.DAL.Business.GetBusinesses(String.Empty)
            Else
                dt = Hydrator.DAL.Business.GetBusinesses(txtSearch.Text)
            End If
            Dim content As String = ""
            content = content & "<thead><tr><tbody>"

            For Each row As DataRow In dt.Rows
                content = content & "<tr>"
                For i As Integer = 0 To dt.Columns.Count - 1 Step 1
                    If (i = 1) Then
                        content = content & String.Format("<td><a href=""Campaigns.aspx?Name={1}&ID={2}"">{0}</a></td>", row(i).ToString(), row("BusinessName"), row("Business_PK"))

                    ElseIf i > 1 And i < 5 Then
                        content = content & String.Format("<td class=""hidden-700"">{0}</td>", row(i).ToString())
                    Else

                        content = content & String.Format("<td>{0}</td>", row(i).ToString())
                    End If
                Next
                content = content & "</tr>"
            Next
            If (dt.Rows.Count = 0) Then
                content = String.Format(content & "<tr><td colspan=""{0}""><center>No records were found!</center></td></tr>", dt.Columns.Count + 1)
            End If
            content = content & "</tbody>"
            Dim lblContent As New Label

            lblContent.Text = content
            PlaceHolder.Controls.Add(lblContent)

        Catch ex As Exception
            Hydrator.DAL.TraceLog.WriteError(0, "page_load - Business.aspx.vb" & ";" & ex.Message, ex.StackTrace)
        End Try

    End Sub

  
End Class