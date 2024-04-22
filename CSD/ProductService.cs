using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using WC_SOAP_DWF.Products;

namespace WC_SOAP_DWF.CSD
{
    public class ProductService
    {

        public List<Products.productInfo> getAllProducts()
        {
            productPortClient service = new productPortClient("productPortSoap11");
            getAllProductsRequest request = new getAllProductsRequest();
            return  new List<Products.productInfo>(service.getAllProducts(request));
        }

        public processStatus InsertarProducto(Products.productInfo productInfo)
        {
            productPortClient service = new productPortClient("productPortSoap11");
            addProductRequest request = new addProductRequest();
            request.name = productInfo.name;
            request.price = productInfo.price;
            request.description = productInfo.description;
            request.category = productInfo.category;
            service.addProduct(request);
            addProductResponse response = service.addProduct(request);

            return response.processStatus;
        }

      
    }
}