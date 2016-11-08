<%@ Page Language="vb" AutoEventWireup="false" CodeFile="BusinessRegistration.aspx.vb" Inherits="BusinessRegistration" MasterPageFile="~/MainMaster.Master" %>

<asp:Content runat="server" ID="businessRegistrationHolder" ContentPlaceHolderID="mainPlaceHolder">
    <p>
        Enter business Name below:
    </p>
    <div class="form-group">
        <label class="control-label col-md-2">
            Business name</label>
        <div class="col-md-5">

            <asp:TextBox ID="txtBusName" runat="server" class="form-control" ></asp:TextBox>


             <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            
      

        </div>

          <asp:Button ID="btnAdd" runat="server" Text="Register" class="btn green button-submit"/>

    </div>

   
</asp:Content>


<asp:Content runat="server" ID="scriptsHolder" ContentPlaceHolderID="scriptsHolder">
    <script type ="text/javascript">
 <asp:Literal ID ="scripts" runat ="server"></asp:Literal>
</script>
 </asp:Content>