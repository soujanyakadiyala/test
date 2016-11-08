<%@ Page Language="vb" AutoEventWireup="false" CodeFile="Business.aspx.vb" Inherits="Business" MasterPageFile="~/MainMaster.Master" %>

<asp:Content runat="server" ID="campaignsHolder" ContentPlaceHolderID="mainPlaceHolder">
   
    <div></div>

      <div class="form-group">
         <label class="control-label col-md-2">Business name</label>


       <div class="col-md-5">
            <asp:TextBox runat="server" ID="txtSearch"
                                onfocus="this.value = this.value;" class="form-control"></asp:TextBox>
                                
</div>

          <div>


          </div>
</div>

          
                <!-- BEGIN GREEN TABLE PORTLET-->
			 
			<br />
      <br />
      <br />
      <br /> 

			 
                  <div class="portlet box green">
                     <div class="portlet-title">
                        <div class="caption"><span align="right"> <a href="BusinessRegistration.aspx" id="register-business" class="btn green pull-left">
        Add New Business&nbsp;<i class="m-icon-swapright m-icon-white"></i></a></span></div>
                        
                     </div>
                         <div class="portlet-body">
						 
						 
						 <div class="tableScroll">
						 
                                                          <table class="table table-striped table-condensed table-bordered dataTable no-footer">
                           <thead>
                              <tr>
                                  <th>
                                      Business_PK</th>
                                  <th>
                                      Business Name</th>
                                      <th class="hidden-700">
                                     Entered</th>
                                
                            
                               </tr>
                           </thead>
                           
  <asp:PlaceHolder ID="PlaceHolder" runat="server"></asp:PlaceHolder>
 
       
                        </table>
            
                  
                      </div>
             </div>
			 
			  </div>
                  <!-- END GREEN TABLE PORTLET-->
           


</asp:Content>

<asp:Content runat ="server" ID="scripts" ContentPlaceHolderID="scriptsHolder">
     
</asp:Content> 
