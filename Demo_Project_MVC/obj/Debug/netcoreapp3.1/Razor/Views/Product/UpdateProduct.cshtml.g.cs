#pragma checksum "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Product\UpdateProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4753d81ece7e7d56e311eb29725f9bb2b5916c3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_UpdateProduct), @"mvc.1.0.view", @"/Views/Product/UpdateProduct.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\_ViewImports.cshtml"
using Demo_Project_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\_ViewImports.cshtml"
using Demo_Project_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4753d81ece7e7d56e311eb29725f9bb2b5916c3f", @"/Views/Product/UpdateProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4021f13b61d069e7a026ba81a07073521603596e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_UpdateProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Demo_Project_MVC.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Product\UpdateProduct.cshtml"
  
    ViewBag.Title = "UpdateProduct";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>UpdateProduct</h2>\r\n\r\n\r\n");
#nullable restore
#line 10 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Product\UpdateProduct.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Product\UpdateProduct.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Product</h4>\r\n        <hr />\r\n        ");
#nullable restore
#line 17 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Product\UpdateProduct.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Product\UpdateProduct.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 21 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Product\UpdateProduct.cshtml"
       Write(Html.LabelFor(model => model.PName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 23 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Product\UpdateProduct.cshtml"
           Write(Html.EditorFor(model => model.PName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 24 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Product\UpdateProduct.cshtml"
           Write(Html.ValidationMessageFor(model => model.PName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 29 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Product\UpdateProduct.cshtml"
       Write(Html.LabelFor(model => model.PQunt, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 31 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Product\UpdateProduct.cshtml"
           Write(Html.EditorFor(model => model.PQunt, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 32 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Product\UpdateProduct.cshtml"
           Write(Html.ValidationMessageFor(model => model.PQunt, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Update\" class=\"btn btn-default\" />\r\n                ");
#nullable restore
#line 39 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Product\UpdateProduct.cshtml"
           Write(Html.ActionLink("Cancel", "DisplayProduct", "Product", new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 44 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Product\UpdateProduct.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo_Project_MVC.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591