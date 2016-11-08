<%@ Page Language="vb" AutoEventWireup="false" CodeFile="Campaigns.aspx.vb" Inherits="Campaigns" MasterPageFile="~/MainMaster.Master" %>
<asp:Content runat="server" ID="campaignsHolder"  ContentPlaceHolderID="mainPlaceHolder">



    <a href="CreateCampaign.aspx" id="register-campaign" class="btn green pull-left">
        Add New Campaign&nbsp;<i class="m-icon-swapright m-icon-white"></i></a>
     <asp:UpdatePanel ID="CampaignUpdatePanel" runat="server">

                <ContentTemplate>
                 
           
       <div class="portlet">
        <div class="portlet-body" style="padding-top:10px">
            <ul class="nav nav-tabs" style="height:42px!important">
                <li class="active" style="height:32px!important"><a href="#tab1" data-toggle="tab">Development </a></li>
                <li style="height:32px!important"><a href="#tab2" data-toggle="tab">Live </a></li>
                <li style="height:32px!important"><a href="#tab3" data-toggle="tab">Completed </a></li>
            </ul>
            <div class="tab-content">
                <div class="tab-pane fade active in" id="tab1">
               <asp:Label ID="lblDev" runat="server"></asp:label>
                </div>
                <div class="tab-pane fade" id="tab2">
               <asp:label ID="lblLive" runat="server"></asp:label>
                </div>
                <div class="tab-pane fade" id="tab3">
               <asp:label ID="lblCompleted" runat="server"></asp:label>
                </div>
            </div>
        </div>
    </div>
    
     
       

         
     </ContentTemplate>

 </asp:UpdatePanel>
</asp:Content> 


