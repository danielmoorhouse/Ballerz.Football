#pragma checksum "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9eaac4d926b59674c313b88de43f9876b22d2edf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stadium_Details), @"mvc.1.0.view", @"/Views/Stadium/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stadium/Details.cshtml", typeof(AspNetCore.Views_Stadium_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eaac4d926b59674c313b88de43f9876b22d2edf", @"/Views/Stadium/Details.cshtml")]
    public class Views_Stadium_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.Stadium>
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
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(103, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(132, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eaac4d926b59674c313b88de43f9876b22d2edf3166", async() => {
                BeginContext(138, 89, true);
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
            BeginContext(234, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(236, 1934, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eaac4d926b59674c313b88de43f9876b22d2edf4424", async() => {
                BeginContext(242, 112, true);
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>Stadium</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(355, 47, false);
#line 21 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StadiumName));

#line default
#line hidden
                EndContext();
                BeginContext(402, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(466, 43, false);
#line 24 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
       Write(Html.DisplayFor(model => model.StadiumName));

#line default
#line hidden
                EndContext();
                BeginContext(509, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(572, 51, false);
#line 27 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StadiumImageUrl));

#line default
#line hidden
                EndContext();
                BeginContext(623, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(687, 47, false);
#line 30 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
       Write(Html.DisplayFor(model => model.StadiumImageUrl));

#line default
#line hidden
                EndContext();
                BeginContext(734, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(797, 45, false);
#line 33 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CountryId));

#line default
#line hidden
                EndContext();
                BeginContext(842, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(906, 41, false);
#line 36 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
       Write(Html.DisplayFor(model => model.CountryId));

#line default
#line hidden
                EndContext();
                BeginContext(947, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(1010, 46, false);
#line 39 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HomeTeamId));

#line default
#line hidden
                EndContext();
                BeginContext(1056, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(1120, 42, false);
#line 42 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
       Write(Html.DisplayFor(model => model.HomeTeamId));

#line default
#line hidden
                EndContext();
                BeginContext(1162, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(1225, 44, false);
#line 45 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Capacity));

#line default
#line hidden
                EndContext();
                BeginContext(1269, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(1333, 40, false);
#line 48 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
       Write(Html.DisplayFor(model => model.Capacity));

#line default
#line hidden
                EndContext();
                BeginContext(1373, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(1436, 44, false);
#line 51 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address1));

#line default
#line hidden
                EndContext();
                BeginContext(1480, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(1544, 40, false);
#line 54 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
       Write(Html.DisplayFor(model => model.Address1));

#line default
#line hidden
                EndContext();
                BeginContext(1584, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(1647, 44, false);
#line 57 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address2));

#line default
#line hidden
                EndContext();
                BeginContext(1691, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(1755, 40, false);
#line 60 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
       Write(Html.DisplayFor(model => model.Address2));

#line default
#line hidden
                EndContext();
                BeginContext(1795, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(1858, 44, false);
#line 63 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PostCode));

#line default
#line hidden
                EndContext();
                BeginContext(1902, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(1966, 40, false);
#line 66 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
       Write(Html.DisplayFor(model => model.PostCode));

#line default
#line hidden
                EndContext();
                BeginContext(2006, 67, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2073, "\"", 2097, 1);
#line 71 "/home/daniel/ASPProjects/Ballerz.Football/Views/Stadium/Details.cshtml"
WriteAttributeValue("", 2088, Model.Id, 2088, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2098, 65, true);
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
            BeginContext(2170, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.Stadium> Html { get; private set; }
    }
}
#pragma warning restore 1591
