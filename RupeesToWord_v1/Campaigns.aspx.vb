Imports System.Data
Partial Class Campaigns
    Inherits System.Web.UI.Page

    Protected Overloads Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim businessID As Integer = 0


            If (Page.Request.QueryString("ID") IsNot Nothing) Then
                Session("BusinessID") = Page.Request.QueryString("ID").ToString()
            End If

            If (Page.Request.QueryString("Name") IsNot Nothing) Then
                Session("BusinessName") = Page.Request.QueryString("Name").ToString()
            End If


        lblDev.Text = WriteHTML(Hydrator.DAL.Campaign.GetCampaigns(ConfigurationManager.AppSettings("CampaignsDevelopment").ToString, Session("BusinessID")), ConfigurationManager.AppSettings("CampaignsDevelopment").ToString)
        lblLive.Text = WriteHTML(Hydrator.DAL.Campaign.GetCampaigns(ConfigurationManager.AppSettings("CampaignsLive").ToString, Session("BusinessID")), ConfigurationManager.AppSettings("CampaignsLive").ToString)
        lblCompleted.Text = WriteHTML(Hydrator.DAL.Campaign.GetCampaigns(ConfigurationManager.AppSettings("CampaignsCompleted").ToString, Session("BusinessID")), ConfigurationManager.AppSettings("CampaignsCompleted").ToString)

        '    liveCampaigns.StatusID = CampaignManagementSystem.DAL.Campaign.CampaignStatus.Live
        '    liveCampaigns.Records = CampaignManagementSystem.DAL.Campaign.GetCampaigns(liveCampaigns.StatusID, Session("BusinessID"), Int32.Parse(Session("lookupval_pk")))

        '    completedCampaigns.StatusID = CampaignManagementSystem.DAL.Campaign.CampaignStatus.Expired
        '    completedCampaigns.Records = CampaignManagementSystem.DAL.Campaign.GetCampaigns(completedCampaigns.StatusID, Session("BusinessID"), Int32.Parse(Session("lookupval_pk")))

        'End If
    End Sub



    Public Function WriteHTML(ByVal dt As DataTable, CampaignStatus As Integer) As String
        Dim content As String = ""
        If (dt IsNot Nothing) Then
            content = "<table width =""100%"" class=""table table-striped table-hover table-bordered dataTable no-footer"" id=""existingCampaign"">"
            content = content & "<tr role=""row""><td valign=""middle""><b>ID</b></td><td valign=""middle""><b>Details</b></td><td valign=""middle""><b>Actions</b></td>"
            For Each row As DataRow In dt.Rows
                content = content & "<tr role=""row"">"
                content = content & String.Format("<td valign=""middle"">{0}</td>", row("CampaignID"))
                content = content & String.Format("<td><table width =""100%""><tr><td><b>{0}</b></td></tr><tr><td>{1}</td></tr><tr><td>{2}</td></tr></table></td>", row("CampaignName"), Left(row("CampaignDescription"), 50), row("CampaignURL"), row("startdate"), row("enddate"))
                If (CampaignStatus = 5) Then
                    content = content & String.Format("<td valign=""middle"">{0}</td>", String.Format("<a href=""CreateCampaign.aspx?CampaignID={0}"">Edit</a> | <a href=""CreateCampaign.aspx?CampaignID={0}"">Launch</a>", row("CampaignID")))
                Else
                    content = content & String.Format("<td valign=""middle"">{0}</td>", String.Format("<a href=""CampaignStats.aspx?C={0}&B={1}"">Stats</a> | <a href=""CreateCampaign.aspx?CampaignID={0}"">View</a>", row("CampaignID"), row("BusID")))
                End If
                content = content & "</tr>"
            Next
            content = content & "</table>"

        End If
        Return Content
    End Function

End Class