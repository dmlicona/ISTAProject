#pragma checksum "D:\ISTAProject\Project_AkA_CakePops_Website_1stPush\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c9fd2661ec8ab233955d36e78c757c7963cd71c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "D:\ISTAProject\Project_AkA_CakePops_Website_1stPush\Views\_ViewImports.cshtml"
using Project_AkA_CakePops_Website;

#line default
#line hidden
#line 2 "D:\ISTAProject\Project_AkA_CakePops_Website_1stPush\Views\_ViewImports.cshtml"
using Project_AkA_CakePops_Website.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c9fd2661ec8ab233955d36e78c757c7963cd71c", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"872710a41a56fe60f8e602f12dd8159f7cd071a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\ISTAProject\Project_AkA_CakePops_Website_1stPush\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact Us...";

#line default
#line hidden
            BeginContext(49, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(54, 17, false);
#line 4 "D:\ISTAProject\Project_AkA_CakePops_Website_1stPush\Views\Home\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(71, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(83, 19, false);
#line 5 "D:\ISTAProject\Project_AkA_CakePops_Website_1stPush\Views\Home\Contact.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(102, 395, true);
            WriteLiteral(@"</h3>

<address>
    123 Somewhere Dr.<br />
    Stafford, VA 22556-1234<br />
    <abbr title=""Phone"">P:</abbr>
    123.456.7890
</address>

<address>
    <strong>Our Email:</strong> <a href=""mailto:AKA_CakePops@gmail.com"">AKA_CakePops@gmail.com</a><br />
    <strong>Our Web Developer:</strong> <a href=""mailto:denis.m.licona@oulook.com"">denis.m.licona@outlook.com</a>
</address>
");
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
