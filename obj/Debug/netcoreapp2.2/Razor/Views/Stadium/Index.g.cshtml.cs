#pragma checksum "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a9f2596d067334c37f26cb832b7f324677876cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stadium_Index), @"mvc.1.0.view", @"/Views/Stadium/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stadium/Index.cshtml", typeof(AspNetCore.Views_Stadium_Index))]
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
#line 1 "/home/daniel/ASPProjects/Ballerz.Football/Views/_ViewImports.cshtml"
using Ballerz.Football;

#line default
#line hidden
#line 2 "/home/daniel/ASPProjects/Ballerz.Football/Views/_ViewImports.cshtml"
using Ballerz.Football.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a9f2596d067334c37f26cb832b7f324677876cb", @"/Views/Stadium/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b04a711db23eb1b161ffd02378a2ea84a8897a9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Stadium_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ballerz.Football.Ballerz.Web.Models.Stadiums.StadiumIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 33, true);
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(104, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a9f2596d067334c37f26cb832b7f324677876cb3785", async() => {
                BeginContext(110, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(204, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(206, 820, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a9f2596d067334c37f26cb832b7f324677876cb5040", async() => {
                BeginContext(212, 11, true);
                WriteLiteral("\r\n<p>\r\n    ");
                EndContext();
                BeginContext(223, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a9f2596d067334c37f26cb832b7f324677876cb5428", async() => {
                    BeginContext(246, 10, true);
                    WriteLiteral("Create New");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(260, 27, true);
                WriteLiteral("\r\n</p>\r\n<div class=\"row\">\r\n");
                EndContext();
#line 17 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Index.cshtml"
 foreach (var item in Model.StadList) {

#line default
#line hidden
                BeginContext(328, 82, true);
                WriteLiteral("    <div class=\"col-md-3 text-center\">\r\n                <p style=\"display: none;\">");
                EndContext();
                BeginContext(411, 7, false);
#line 19 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Index.cshtml"
                                     Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(418, 68, true);
                WriteLiteral("</p>\r\n               \r\n          \r\n                \r\n           <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 486, "\"", 513, 1);
#line 23 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Index.cshtml"
WriteAttributeValue("", 492, item.StadiumImageUrl, 492, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(514, 69, true);
                WriteLiteral(" style=\"width: 90%; border-radius: 25px;\" />\r\n           <h5><strong>");
                EndContext();
                BeginContext(584, 16, false);
#line 24 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Index.cshtml"
                  Write(item.StadiumName);

#line default
#line hidden
                EndContext();
                BeginContext(600, 61, true);
                WriteLiteral("</strong></h5> \r\n         \r\n            \r\n               <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 661, "\"", 685, 1);
#line 27 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Index.cshtml"
WriteAttributeValue("", 667, item.ClubBadgeUrl, 667, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(686, 114, true);
                WriteLiteral(" style=\"width: 25%\" /> \r\n         \r\n         \r\n         \r\n                <!-- <a asp-action=\"Edit\" asp-route-id=\"");
                EndContext();
                BeginContext(801, 7, false);
#line 31 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Index.cshtml"
                                                   Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(808, 68, true);
                WriteLiteral("\">Edit</a> |\r\n                <a asp-action=\"Details\" asp-route-id=\"");
                EndContext();
                BeginContext(877, 7, false);
#line 32 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Index.cshtml"
                                                 Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(884, 70, true);
                WriteLiteral("\">Details</a> |\r\n                <a asp-action=\"Delete\" asp-route-id=\"");
                EndContext();
                BeginContext(955, 7, false);
#line 33 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Index.cshtml"
                                                Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(962, 42, true);
                WriteLiteral("\">Delete</a> -->\r\n                </div>\r\n");
                EndContext();
#line 35 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Index.cshtml"
    }

#line default
#line hidden
                BeginContext(1011, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1026, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ballerz.Football.Ballerz.Web.Models.Stadiums.StadiumIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
