#pragma checksum "/home/daniel/ASPProjects/Ballerz.Football/Views/StadiumImages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "703b064cf24a5e84350fbb7023596a31fde6d98e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StadiumImages_Index), @"mvc.1.0.view", @"/Views/StadiumImages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StadiumImages/Index.cshtml", typeof(AspNetCore.Views_StadiumImages_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"703b064cf24a5e84350fbb7023596a31fde6d98e", @"/Views/StadiumImages/Index.cshtml")]
    public class Views_StadiumImages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.StadiumImages>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(93, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/daniel/ASPProjects/Ballerz.Football/Views/StadiumImages/Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(122, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(151, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "703b064cf24a5e84350fbb7023596a31fde6d98e3217", async() => {
                BeginContext(157, 87, true);
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
            BeginContext(251, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(253, 1157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "703b064cf24a5e84350fbb7023596a31fde6d98e4473", async() => {
                BeginContext(259, 140, true);
                WriteLiteral("\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(400, 45, false);
#line 22 "/home/daniel/ASPProjects/Ballerz.Football/Views/StadiumImages/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StadiumId));

#line default
#line hidden
                EndContext();
                BeginContext(445, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(501, 51, false);
#line 25 "/home/daniel/ASPProjects/Ballerz.Football/Views/StadiumImages/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StadiumImageUrl));

#line default
#line hidden
                EndContext();
                BeginContext(552, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(608, 48, false);
#line 28 "/home/daniel/ASPProjects/Ballerz.Football/Views/StadiumImages/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ImageCaption));

#line default
#line hidden
                EndContext();
                BeginContext(656, 86, true);
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
                EndContext();
#line 34 "/home/daniel/ASPProjects/Ballerz.Football/Views/StadiumImages/Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
                BeginContext(774, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(823, 44, false);
#line 37 "/home/daniel/ASPProjects/Ballerz.Football/Views/StadiumImages/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StadiumId));

#line default
#line hidden
                EndContext();
                BeginContext(867, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(923, 50, false);
#line 40 "/home/daniel/ASPProjects/Ballerz.Football/Views/StadiumImages/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StadiumImageUrl));

#line default
#line hidden
                EndContext();
                BeginContext(973, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1029, 47, false);
#line 43 "/home/daniel/ASPProjects/Ballerz.Football/Views/StadiumImages/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ImageCaption));

#line default
#line hidden
                EndContext();
                BeginContext(1076, 75, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1151, "\"", 1174, 1);
#line 46 "/home/daniel/ASPProjects/Ballerz.Football/Views/StadiumImages/Index.cshtml"
WriteAttributeValue("", 1166, item.Id, 1166, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1175, 52, true);
                WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1227, "\"", 1250, 1);
#line 47 "/home/daniel/ASPProjects/Ballerz.Football/Views/StadiumImages/Index.cshtml"
WriteAttributeValue("", 1242, item.Id, 1242, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1251, 54, true);
                WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1305, "\"", 1328, 1);
#line 48 "/home/daniel/ASPProjects/Ballerz.Football/Views/StadiumImages/Index.cshtml"
WriteAttributeValue("", 1320, item.Id, 1320, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1329, 47, true);
                WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 51 "/home/daniel/ASPProjects/Ballerz.Football/Views/StadiumImages/Index.cshtml"
}

#line default
#line hidden
                BeginContext(1379, 24, true);
                WriteLiteral("    </tbody>\r\n</table>\r\n");
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
            BeginContext(1410, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.StadiumImages>> Html { get; private set; }
    }
}
#pragma warning restore 1591