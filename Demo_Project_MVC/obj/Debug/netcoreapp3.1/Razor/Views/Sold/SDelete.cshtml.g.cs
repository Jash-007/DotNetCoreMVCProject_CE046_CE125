#pragma checksum "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "261e2a6160ae28caa378cabc47f7802bb7341910"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sold_SDelete), @"mvc.1.0.view", @"/Views/Sold/SDelete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"261e2a6160ae28caa378cabc47f7802bb7341910", @"/Views/Sold/SDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4021f13b61d069e7a026ba81a07073521603596e", @"/Views/_ViewImports.cshtml")]
    public class Views_Sold_SDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Demo_Project_MVC.Models.Sold>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDelete.cshtml"
  
    ViewBag.Title = "SDelete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>SDelete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Sold</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 15 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.SName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 19 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDelete.cshtml"
       Write(Html.DisplayFor(model => model.SName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 23 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.SQunt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 27 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDelete.cshtml"
       Write(Html.DisplayFor(model => model.SQunt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 31 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.SDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 35 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDelete.cshtml"
       Write(Html.DisplayFor(model => model.SDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");
#nullable restore
#line 40 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDelete.cshtml"
     using (Html.BeginForm()) {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDelete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-actions no-color\">\r\n    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n    ");
#nullable restore
#line 45 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDelete.cshtml"
Write(Html.ActionLink("Cancel", "DisplaySold", "Sold", new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
#nullable restore
#line 48 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDelete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo_Project_MVC.Models.Sold> Html { get; private set; }
    }
}
#pragma warning restore 1591
