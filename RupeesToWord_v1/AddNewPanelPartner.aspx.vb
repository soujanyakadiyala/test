Imports System.Data

Partial Class AddNewPanelPartner
    Inherits System.Web.UI.Page
    Private Sub CreatePanelParter()
        Try


             Dim id As Integer = Hydrator.DAL.Business.CreatePanelPartner(txtPartnerName.Text)

            If id = 1 Then

                lblMessage.Text = "Already have the Panel Partner"+ "&nbsp;" + txtPartnerName.Text + "&nbsp;" + "in the system"
                txtPartnerName.Text = ""

            Else

                BindData()
                lblMessage.Text = "Created the new Panel Partner" + "&nbsp;" + txtPartnerName.Text
                txtPartnerName.Text = ""

            End If
       


 Catch ex As Exception
            Hydrator.DAL.TraceLog.WriteError(0, "CreatePanelParter: AddNewPanelPartner.aspx" & ";" & ex.Message, ex.StackTrace)
        End Try
    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As System.EventArgs) Handles btnAdd.Click
        CreatePanelParter()
    End Sub


Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        Dim id As HtmlGenericControl

        id = Page.Master.FindControl("lippartner")

        id.Attributes("class") = "active"

        If Not IsPostBack Then
            BindData()
        End If


    End Sub


    Private Sub BindData()

        Dim Dtpanelpartner As DataTable
        Dtpanelpartner = Hydrator.DAL.Business.GetALLPanelPartners()
        If Dtpanelpartner.Rows.Count <> 0 Then
            GridViewPanelPartners.DataSource = Dtpanelpartner
            GridViewPanelPartners.DataBind()
        End If
    End Sub




End Class
