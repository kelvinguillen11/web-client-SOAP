<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="WC_SOAP_DWF.CSU.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Producto</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid bg-success min-vh-100">
            <div class="toast-container position-fixed bottom-0 end-0 p-3">
  <div id="liveToast" class="toast" role="alert" aria-live="assertive" aria-atomic="true">
    <div class="toast-header">
      <strong class="me-auto">Bootstrap</strong>
      <small><asp:Label ID="StatusCode" runat="server"/></small>
      <button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
    </div>
    <div class="toast-body">
     <asp:Label ID="MessageCode" runat="server"/>
    </div>
  </div>
</div>
         <div class="container-fluid">
            
             <div class="mb-3">
                <asp:Label AssociatedControlID="txtName"  CssClass="form-label" runat="server" >Nombre</asp:Label>
                 <asp:TextBox ID="txtName"  CssClass="form-control" runat="server"/>
             </div>
               <div class="mb-3">
     <asp:Label AssociatedControlID="txtPrice"  CssClass="form-label" runat="server" >Precio</asp:Label>
      <asp:TextBox ID="txtPrice"  CssClass="form-control" runat="server"/>
  </div>
               <div class="mb-3">
     <asp:Label AssociatedControlID="txtCategory"  CssClass="form-label" runat="server" >Categoria</asp:Label>
      <asp:TextBox ID="txtCategory"  CssClass="form-control" runat="server"/>
  </div>
               <div class="mb-3">
     <asp:Label AssociatedControlID="txtDescription"  CssClass="form-label" runat="server" >Descripcion</asp:Label>
      <asp:TextBox ID="txtDescription"  CssClass="form-control" runat="server"/>
           
                   <div class="mb-3">
                       <asp:Button ID="BtnRegister" CssClass="btn btn-primary" runat="server" Text="Registrar producto" OnClick="BtnRegister_Click" />
                   </div>
        </div>
         </div>

            <div class="container-fluid bg-light mb-3">
               <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False" CssClass="table">
    <Columns>
        <asp:BoundField DataField="id" HeaderText="ID" />
        <asp:BoundField DataField="name" HeaderText="Nombre del Producto" />
        <asp:BoundField DataField="price" HeaderText="Precio" />
        <asp:BoundField DataField="category" HeaderText="Categoria" />
        <asp:BoundField DataField="description" HeaderText="Descripcion" />
    </Columns>
</asp:GridView>
            </div>
        </div>
      </form>
    <script async="async">
        const toastTrigger = document.getElementById('BtnRegister');
        const toastMessage = document.getElementById('liveToast');

        if (toastTrigger) {
            const toastBootstrap = Bootstrap.Toast.getOrCreateInstance(toastMessage);
            toastTrigger.addEventListener('click', () => {
                toastBootstrap.show()
            })
        }
    </script>
</body>
</html>
