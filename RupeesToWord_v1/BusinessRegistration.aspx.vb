Imports System.Data
Partial Class BusinessRegistration
    Inherits System.Web.UI.Page
    Protected Overloads Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)

      

    End Sub

    Private Sub CreateBusiness()
        Try
            Dim id As Integer = Hydrator.DAL.Business.CreateBusiness(txtBusName.Text)



            If id = 1 Then

                lblMessage.Text = "Already have the Business" + "&nbsp;" + txtBusName.Text + "&nbsp;" + "in the system"
                txtBusName.Text = ""

            Else

                CreateBusiness()
                Response.Redirect("Business.aspx", False)
                txtBusName.Text = ""

            End If




        Catch ex As Exception
            Hydrator.DAL.TraceLog.WriteError(0, "CreateBusiness: Business.aspx" & ";" & ex.Message, ex.StackTrace)
        End Try
    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As System.EventArgs) Handles btnAdd.Click
        CreateBusiness()
    End Sub
End Class