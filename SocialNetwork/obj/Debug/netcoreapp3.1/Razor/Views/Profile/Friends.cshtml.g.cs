#pragma checksum "F:\ProjectCSharp\SocialNetwork\SocialNetwork\SocialNetwork\Views\Profile\Friends.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c143675ccb16f3b60a1b6017bea81d8bbf7c477"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Friends), @"mvc.1.0.view", @"/Views/Profile/Friends.cshtml")]
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
#line 1 "F:\ProjectCSharp\SocialNetwork\SocialNetwork\SocialNetwork\Views\_ViewImports.cshtml"
using SocialNetwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ProjectCSharp\SocialNetwork\SocialNetwork\SocialNetwork\Views\_ViewImports.cshtml"
using SocialNetwork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c143675ccb16f3b60a1b6017bea81d8bbf7c477", @"/Views/Profile/Friends.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f753f9608fdc9f7cfcaef4fd6b8f21361e1f0383", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Friends : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <h3>\r\n        HALLO\r\n        ");
#nullable restore
#line 9 "F:\ProjectCSharp\SocialNetwork\SocialNetwork\SocialNetwork\Views\Profile\Friends.cshtml"
   Write(User.FindFirst("UserId").Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    </h3>\r\n</div>");
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
