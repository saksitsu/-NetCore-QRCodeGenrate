#pragma checksum "D:\WORK\GIT\GITHUB\QRCodeGenrator\QRCodeGenrator\Views\Home\QRCode.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a6f9aa16ded0e60c713faa12c15243c8e08910c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_QRCode), @"mvc.1.0.view", @"/Views/Home/QRCode.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/QRCode.cshtml", typeof(AspNetCore.Views_Home_QRCode))]
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
#line 1 "D:\WORK\GIT\GITHUB\QRCodeGenrator\QRCodeGenrator\Views\_ViewImports.cshtml"
using QRCodeGenrator;

#line default
#line hidden
#line 2 "D:\WORK\GIT\GITHUB\QRCodeGenrator\QRCodeGenrator\Views\_ViewImports.cshtml"
using QRCodeGenrator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a6f9aa16ded0e60c713faa12c15243c8e08910c", @"/Views/Home/QRCode.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3401d829750555aaf4a93c97d52695b770ac7a8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_QRCode : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\WORK\GIT\GITHUB\QRCodeGenrator\QRCodeGenrator\Views\Home\QRCode.cshtml"
  
    ViewData["Title"] = "QRCode";

#line default
#line hidden
            BeginContext(44, 25, true);
            WriteLiteral("\r\n<h2>QRCode</h2>\r\n\r\n<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 69, "\"", 107, 1);
#line 8 "D:\WORK\GIT\GITHUB\QRCodeGenrator\QRCodeGenrator\Views\Home\QRCode.cshtml"
WriteAttributeValue("", 75, Url.Action("GET_QR","SERVICES"), 75, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(108, 28, true);
            WriteLiteral(" width=\"100\" height=\"100\" />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
