#pragma checksum "C:\VISUALSTUDIOCODE\TESTSERVER\ROLESBASED\ShowFieldByUser\Views\ManageUsers\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84112727f50ec3423cee60b60f98636075544ab5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageUsers_Index2), @"mvc.1.0.view", @"/Views/ManageUsers/Index2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ManageUsers/Index2.cshtml", typeof(AspNetCore.Views_ManageUsers_Index2))]
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
#line 1 "C:\VISUALSTUDIOCODE\TESTSERVER\ROLESBASED\ShowFieldByUser\Views\_ViewImports.cshtml"
using ShowFieldByUser;

#line default
#line hidden
#line 2 "C:\VISUALSTUDIOCODE\TESTSERVER\ROLESBASED\ShowFieldByUser\Views\_ViewImports.cshtml"
using ShowFieldByUser.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84112727f50ec3423cee60b60f98636075544ab5", @"/Views/ManageUsers/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"490e5ad0e81ad960760ff92501ac0c4148d02b07", @"/Views/_ViewImports.cshtml")]
    public class Views_ManageUsers_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ManageUsersViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 117, true);
            WriteLiteral("    For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860\r\n\r\n");
            EndContext();
#line 4 "C:\VISUALSTUDIOCODE\TESTSERVER\ROLESBASED\ShowFieldByUser\Views\ManageUsers\Index2.cshtml"
  
    ViewData["Title"] = "Manage users";

#line default
#line hidden
            BeginContext(194, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(201, 17, false);
#line 8 "C:\VISUALSTUDIOCODE\TESTSERVER\ROLESBASED\ShowFieldByUser\Views\ManageUsers\Index2.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(218, 141, true);
            WriteLiteral("</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <td>Id</td>\r\n            <td>Email</td>\r\n        </tr>\r\n    </thead>\r\n");
            EndContext();
#line 17 "C:\VISUALSTUDIOCODE\TESTSERVER\ROLESBASED\ShowFieldByUser\Views\ManageUsers\Index2.cshtml"
     foreach (var user in Model.Administrators)
    {

#line default
#line hidden
            BeginContext(415, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(438, 7, false);
#line 20 "C:\VISUALSTUDIOCODE\TESTSERVER\ROLESBASED\ShowFieldByUser\Views\ManageUsers\Index2.cshtml"
       Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(445, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(465, 10, false);
#line 21 "C:\VISUALSTUDIOCODE\TESTSERVER\ROLESBASED\ShowFieldByUser\Views\ManageUsers\Index2.cshtml"
       Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(475, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 23 "C:\VISUALSTUDIOCODE\TESTSERVER\ROLESBASED\ShowFieldByUser\Views\ManageUsers\Index2.cshtml"

    }

#line default
#line hidden
            BeginContext(502, 161, true);
            WriteLiteral("</table>\r\n<h3>Everyone</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <td>Id</td>\r\n            <td>Email</td>\r\n        </tr>\r\n    </thead>\r\n");
            EndContext();
#line 34 "C:\VISUALSTUDIOCODE\TESTSERVER\ROLESBASED\ShowFieldByUser\Views\ManageUsers\Index2.cshtml"
     foreach (var user in Model.Everyone)   

        {

#line default
#line hidden
            BeginContext(722, 27, true);
            WriteLiteral("        <tr>\r\n        <td> ");
            EndContext();
            BeginContext(750, 7, false);
#line 38 "C:\VISUALSTUDIOCODE\TESTSERVER\ROLESBASED\ShowFieldByUser\Views\ManageUsers\Index2.cshtml"
        Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(757, 21, true);
            WriteLiteral(" </td>\r\n        <td> ");
            EndContext();
            BeginContext(779, 10, false);
#line 39 "C:\VISUALSTUDIOCODE\TESTSERVER\ROLESBASED\ShowFieldByUser\Views\ManageUsers\Index2.cshtml"
        Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(789, 23, true);
            WriteLiteral(" </td>\r\n        </tr>\r\n");
            EndContext();
#line 41 "C:\VISUALSTUDIOCODE\TESTSERVER\ROLESBASED\ShowFieldByUser\Views\ManageUsers\Index2.cshtml"
        }

#line default
#line hidden
            BeginContext(823, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ManageUsersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
