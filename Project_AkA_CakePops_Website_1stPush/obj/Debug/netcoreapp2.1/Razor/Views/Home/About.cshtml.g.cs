#pragma checksum "C:\Users\denys\ISTAProject\Project_AkA_CakePops_Website\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "240cbcff787cde3c80eab142353510273757149a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\denys\ISTAProject\Project_AkA_CakePops_Website\Views\_ViewImports.cshtml"
using Project_AkA_CakePops_Website;

#line default
#line hidden
#line 2 "C:\Users\denys\ISTAProject\Project_AkA_CakePops_Website\Views\_ViewImports.cshtml"
using Project_AkA_CakePops_Website.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"240cbcff787cde3c80eab142353510273757149a", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"872710a41a56fe60f8e602f12dd8159f7cd071a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\denys\ISTAProject\Project_AkA_CakePops_Website\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About Us";

#line default
#line hidden
            BeginContext(44, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(49, 17, false);
#line 4 "C:\Users\denys\ISTAProject\Project_AkA_CakePops_Website\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(66, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(78, 19, false);
#line 5 "C:\Users\denys\ISTAProject\Project_AkA_CakePops_Website\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(97, 169, true);
            WriteLiteral("</h3>\r\n\r\n<p>Two little entrepreneurs, doing what we love, to earn money to go on our dream vacation to Disney World & Universal Studios. Thank you for the support!</p>\r\n");
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