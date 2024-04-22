using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WC_SOAP_DWF.CSD;
using WC_SOAP_DWF.Products;

namespace WC_SOAP_DWF.CSU
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindGridView();
            }
        }
        private void BindGridView()
        {
        ProductService productService = new ProductService();
           List<Products.productInfo> list = productService.getAllProducts();
            gvProducts.DataSource = list;
            gvProducts.DataBind();
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            Products.productInfo productInfo = new Products.productInfo();
            ProductService productService = new ProductService();
            processStatus  process= new processStatus();

            
            productInfo.name = txtName.Text;
            productInfo.price = double.Parse(txtPrice.Text);
            productInfo.description = txtDescription.Text;
            productInfo.category = txtCategory.Text;

            process = productService.InsertarProducto(productInfo);

            StatusCode.Text = process.StatusCode;
            MessageCode.Text = process.message;
           
        }
    }
}