#pragma checksum "/home/daniel/ASPProjects/Ballerz.Football/Views/Competitions/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bca790211c1435e00f7f6880ddd44d82f5554ec1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Competitions_Details), @"mvc.1.0.view", @"/Views/Competitions/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Competitions/Details.cshtml", typeof(AspNetCore.Views_Competitions_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bca790211c1435e00f7f6880ddd44d82f5554ec1", @"/Views/Competitions/Details.cshtml")]
    public class Views_Competitions_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.Competitions>
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
            BeginContext(79, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/daniel/ASPProjects/Ballerz.Football/Views/Competitions/Details.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(108, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(137, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bca790211c1435e00f7f6880ddd44d82f5554ec13211", async() => {
                BeginContext(143, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
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
            BeginContext(239, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(241, 1079, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bca790211c1435e00f7f6880ddd44d82f5554ec14469", async() => {
                BeginContext(247, 117, true);
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>Competitions</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(365, 45, false);
#line 21 "/home/daniel/ASPProjects/Ballerz.Football/Views/Competitions/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CountryId));

#line default
#line hidden
                EndContext();
                BeginContext(410, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(474, 41, false);
#line 24 "/home/daniel/ASPProjects/Ballerz.Football/Views/Competitions/Details.cshtml"
       Write(Html.DisplayFor(model => model.CountryId));

#line default
#line hidden
                EndContext();
                BeginContext(515, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(578, 46, false);
#line 27 "/home/daniel/ASPProjects/Ballerz.Football/Views/Competitions/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompTypeId));

#line default
#line hidden
                EndContext();
                BeginContext(624, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(688, 42, false);
#line 30 "/home/daniel/ASPProjects/Ballerz.Football/Views/Competitions/Details.cshtml"
       Write(Html.DisplayFor(model => model.CompTypeId));

#line default
#line hidden
                EndContext();
                BeginContext(730, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(793, 44, false);
#line 33 "/home/daniel/ASPProjects/Ballerz.Football/Views/Competitions/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompName));

#line default
#line hidden
                EndContext();
                BeginContext(837, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(901, 40, false);
#line 36 "/home/daniel/ASPProjects/Ballerz.Football/Views/Competitions/Details.cshtml"
       Write(Html.DisplayFor(model => model.CompName));

#line default
#line hidden
                EndContext();
                BeginContext(941, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(1004, 46, false);
#line 39 "/home/daniel/ASPProjects/Ballerz.Football/Views/Competitions/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompImgUrl));

#line default
#line hidden
                EndContext();
                BeginContext(1050, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(1114, 42, false);
#line 42 "/home/daniel/ASPProjects/Ballerz.Football/Views/Competitions/Details.cshtml"
       Write(Html.DisplayFor(model => model.CompImgUrl));

#line default
#line hidden
                EndContext();
                BeginContext(1156, 67, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1223, "\"", 1247, 1);
#line 47 "/home/daniel/ASPProjects/Ballerz.Football/Views/Competitions/Details.cshtml"
WriteAttributeValue("", 1238, Model.Id, 1238, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1248, 65, true);
                WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
            BeginContext(1320, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.Competitions> Html { get; private set; }
    }
}
#pragma warning restore 1591
