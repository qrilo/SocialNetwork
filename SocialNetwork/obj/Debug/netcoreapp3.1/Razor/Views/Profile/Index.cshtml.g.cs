#pragma checksum "F:\ProjectCSharp\SocialNetwork\SocialNetwork\SocialNetwork\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a27b07b09a86af05a435ddc38b9293c5132da3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
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
#nullable restore
#line 2 "F:\ProjectCSharp\SocialNetwork\SocialNetwork\SocialNetwork\Views\Profile\Index.cshtml"
using SocialNetwork.WEB.ViewModels.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a27b07b09a86af05a435ddc38b9293c5132da3b", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f753f9608fdc9f7cfcaef4fd6b8f21361e1f0383", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SocialNetwork.WEB.ViewModels.UserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\ProjectCSharp\SocialNetwork\SocialNetwork\SocialNetwork\Views\Profile\Index.cshtml"
  
    bool MyProfile = (Model.ActionType == ActionType.MyProfile);
    ViewData["Title"] = (MyProfile ? @Model.Name + " " + @Model.Surname : "My Profile");
    string action = (MyProfile ? "MyProfile" : "NotMyProfile");


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-xl-3 col-avatar\">\r\n            <div class=\"avatar-container\">\r\n                <div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a27b07b09a86af05a435ddc38b9293c5132da3b5728", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-xl-8 col-info\">\r\n            <div class=\"name-surname\">\r\n                <h1>");
#nullable restore
#line 20 "F:\ProjectCSharp\SocialNetwork\SocialNetwork\SocialNetwork\Views\Profile\Index.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 20 "F:\ProjectCSharp\SocialNetwork\SocialNetwork\SocialNetwork\Views\Profile\Index.cshtml"
                            Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n            </div>\r\n            <hr/>\r\n            <div class=\"user-info\">\r\n                <h6>City: </h6>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-xl-3 col-friends\">\r\n            <div>\r\n");
#nullable restore
#line 29 "F:\ProjectCSharp\SocialNetwork\SocialNetwork\SocialNetwork\Views\Profile\Index.cshtml"
                 if (MyProfile)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a27b07b09a86af05a435ddc38b9293c5132da3b8008", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "F:\ProjectCSharp\SocialNetwork\SocialNetwork\SocialNetwork\Views\Profile\Index.cshtml"
                                                                                WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 32 "F:\ProjectCSharp\SocialNetwork\SocialNetwork\SocialNetwork\Views\Profile\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn\" href=\"#\" id=\"addToFriend-btn\">Add to friend</a>\r\n");
#nullable restore
#line 36 "F:\ProjectCSharp\SocialNetwork\SocialNetwork\SocialNetwork\Views\Profile\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <hr style=""margin-bottom: 2px;"" />
            </div>
            <div>
                <a href=""#"">
                    <div class=""friends"">
                        <p>Friends</p>
                    </div>
                </a>
                <div style="" display: flex; justify-content: space-around; flex-wrap: wrap;"">
");
#nullable restore
#line 46 "F:\ProjectCSharp\SocialNetwork\SocialNetwork\SocialNetwork\Views\Profile\Index.cshtml"
                     for (int i = 0; i < 6; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"padding: 0\">\r\n                        <div class=\"user-friend\">\r\n                        </div>\r\n                        <p style=\"font-size: 12px\">Name + Surname</p>\r\n                    </div>\r\n");
#nullable restore
#line 53 "F:\ProjectCSharp\SocialNetwork\SocialNetwork\SocialNetwork\Views\Profile\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            </div>\r\n            <div class=\"col-xl-8 col-wall\"><h3>Posts</h3></div>\r\n        </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        body {
            background-color: #EDF2F6;
            color: #42404B;
        }
        .col-avatar {
            margin: 0 20px 20px 20px;
            background: #FFFFFF;
            height: 250px;
        }
        .col-info {
            margin: 0 20px 20px 20px;
            background: #FFFFFF;
            height: 250px;
        }
        .col-friends {
            margin: 0 20px 20px 20px;
            background: #FFFFFF;
            height: 400px;
        }
        .col-wall {
            margin: 0 20px 20px 20px;
            background: #FFFFFF;
            height: 400px;
        }
        .avatar {
            display: block;
            margin: 12px auto 0 auto;
            border-radius: 120px;
        }
        .name-surname {
            padding: 30px 0 0 30px;
        }
        .user-info {
            padding: 10px 0 0 30px;
        }
        .btn {
            width: 100%;
            background: #4A4C63;
            color: white");
                WriteLiteral(@";
            padding: 8px;
            margin-top: 20px;
        }
        .friends {
            height: 30px;
            background: #FFFFFF;
        }
        .friends p {
            text-align: center;
            text-decoration: none;
            color: #4A4C63;
        }
        .friends :hover {
            text-decoration: none;
        }
        .user-friend {
            height: 50px;
            margin: 0px 5px 0px 5px;
            flex: 1 5 calc(100% / 3 - 10px);
            background: red;
        }

        ");
                WriteLiteral("@media (max-width: 1200px) {\r\n            .name-surname {\r\n                text-align: center;\r\n            }\r\n        }\r\n\r\n\r\n\r\n    </style>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SocialNetwork.WEB.ViewModels.UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591