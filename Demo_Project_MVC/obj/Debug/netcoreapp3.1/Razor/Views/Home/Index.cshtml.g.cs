#pragma checksum "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ba9ff09550d0fb13949e95cecfd52d2dc7f9fc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ba9ff09550d0fb13949e95cecfd52d2dc7f9fc0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4021f13b61d069e7a026ba81a07073521603596e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""jumbotron"">
    <div>
        <h1>SalesHub</h1>
        <img src=""https://www.mishainfotech.com/images/InventoryManagement.png"" height=""200px"" width=""100%"" />
    </div>
</div>

<div class=""row"">
    <div class=""col-md-4"">
        <h2>Products Details</h2>
        <p>
            You will get the products details and you can add see details and delete the product from the data. You will be provided with the list of the product which are currently present and how much quantity of products are there.
        </p>
        <p><a class=""btn btn-primary"" href=""https://localhost:44371/Product/DisplayProduct"">Products &raquo;</a></p>
    </div>
    <div class=""col-md-4"">
        <h2>Sale Details</h2>
        <p>You will get the Sales details and you can add see details and delete the product from the data that how much products are sold from the stocks. You will be provided with the list of the product which are sold by the company.</p>
        <p><a class=""btn btn-danger"" href=""https:");
            WriteLiteral(@"//localhost:44371/Sold/DisplaySold"">Sales &raquo;</a></p>
    </div>
    <div class=""col-md-4"">
        <h2>Purshace Details</h2>
        <p>You will get the Product Purchase details and you can add see details and delete the product from the data that how much products you have purchased & add to the stocks. You will be provided with the list of the product which are purchased by the company.</p>
        <p><a class=""btn btn-success"" href=""https://localhost:44371/Bought/DisplayBought"">Purchase &raquo;</a></p>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
