<%@ Page Title="" Language="VB" MasterPageFile="~/MainMaster.Master" AutoEventWireup="false" CodeFile="AddNewPanelPartner.aspx.vb" Inherits="AddNewPanelPartner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainPlaceHolder" Runat="Server">
    <%--<p>
        Enter new Panel Partner Name below:
    </p>
--%>

    
    <div>dsdsdsd</div>
     
<div class="form-group">
        <label class="control-label col-md-2">
           Enter Panel Partner name</label>
        <div class="col-md-5">
        
            <asp:TextBox ID="txtPartnerName" runat="server" class="form-control"></asp:TextBox>

             <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            
      

        </div>
    
 <asp:Button ID="btnAdd" runat="server" Text="Create" class="btn green button-submit"/>


</div>


    <div></div>
 

    

    <div>
    


    <div class="col-md-12">


    <br /><br />

      <div class="portlet box green">
                     <div class="portlet-title">
                        <div class="caption">Panel Partner</div>
                        
                     </div>
                         <div class="portlet-body">


                                                              <div id="DVGrid2">
                                                                  <asp:GridView ID="GridViewPanelPartners" runat="server" AutoGenerateColumns="false"
                                                                      Font-Names="Arial" Font-Size="Smaller" AlternatingRowStyle-BackColor="#C2D69B"
                                                                      HeaderStyle-BackColor="green" AllowPaging="False" ShowFooter="true" PageSize="10"
                                                                      CssClass="table table-striped table-condensed table-bordered dataTable no-footer">
                                                                      <Columns>
                                                                          <asp:TemplateField HeaderText="Panel Partner Id">
                                                                              <ItemTemplate>
                                                                                  <asp:Label ID="lblPartner_pk" runat="server" Text='<%# Eval("Partner_pk")%>'></asp:Label>
                                                                              </ItemTemplate>
                                                                             
                                                                          </asp:TemplateField>
                                                                          <asp:TemplateField HeaderText="Panel Partner Name">
                                                                              <ItemTemplate>
                                                                                  <asp:Label ID="lblPartnerName" runat="server" Text='<%# Eval("PartnerName")%>'></asp:Label>
                                                                              </ItemTemplate>
                                                                          </asp:TemplateField>
                                                                       
                                                                          <asp:TemplateField HeaderText="Entered">
                                                                              <ItemTemplate>
                                                                                  <asp:Label ID="lblentered" runat="server" Text='<%# Eval("Entered")%>'></asp:Label>
                                                                              </ItemTemplate>
                                                                          </asp:TemplateField>
                                                                        
                                                                          
                                                                      </Columns>
                                                                      <AlternatingRowStyle BackColor="LightYellow" />
                                                                      <HeaderStyle BackColor="Gainsboro" />
                                                                  </asp:GridView>
                                                              </div>
                                                          </div>


                                                          </div>
                                                          </div>

    
    
    </div>




</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="scriptsHolder" Runat="Server">
</asp:Content>

