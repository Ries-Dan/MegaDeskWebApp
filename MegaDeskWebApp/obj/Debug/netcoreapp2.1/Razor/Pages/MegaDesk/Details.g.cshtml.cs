#pragma checksum "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8247c114437af755300b4d8828b283d3b5fbd249"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MegaDeskWebApp.Pages.MegaDesk.Pages_MegaDesk_Details), @"mvc.1.0.razor-page", @"/Pages/MegaDesk/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/MegaDesk/Details.cshtml", typeof(MegaDeskWebApp.Pages.MegaDesk.Pages_MegaDesk_Details), null)]
namespace MegaDeskWebApp.Pages.MegaDesk
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\_ViewImports.cshtml"
using MegaDeskWebApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8247c114437af755300b4d8828b283d3b5fbd249", @"/Pages/MegaDesk/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"639e3b606a4580bcfed8657d0b3183f6646b0f72", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MegaDesk_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(103, 123, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>DeskQuote</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(227, 54, false);
#line 15 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.CustName));

#line default
#line hidden
            EndContext();
            BeginContext(281, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(325, 50, false);
#line 18 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.CustName));

#line default
#line hidden
            EndContext();
            BeginContext(375, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(419, 55, false);
#line 21 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.DeskWidth));

#line default
#line hidden
            EndContext();
            BeginContext(474, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(518, 51, false);
#line 24 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.DeskWidth));

#line default
#line hidden
            EndContext();
            BeginContext(569, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(613, 55, false);
#line 27 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.DeskDepth));

#line default
#line hidden
            EndContext();
            BeginContext(668, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(712, 51, false);
#line 30 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.DeskDepth));

#line default
#line hidden
            EndContext();
            BeginContext(763, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(807, 57, false);
#line 33 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.DeskDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(864, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(908, 53, false);
#line 36 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.DeskDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(961, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1005, 54, false);
#line 39 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Material));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1103, 50, false);
#line 42 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Material));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1197, 54, false);
#line 45 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.RushDays));

#line default
#line hidden
            EndContext();
            BeginContext(1251, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1295, 50, false);
#line 48 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.RushDays));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1389, 59, false);
#line 51 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.DeskQuoteDate));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1492, 55, false);
#line 54 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.DeskQuoteDate));

#line default
#line hidden
            EndContext();
            BeginContext(1547, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1591, 60, false);
#line 57 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.DeskQuoteTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1651, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1695, 56, false);
#line 60 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.DeskQuoteTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1751, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1798, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ef30d96d6a343cda6f255fe4b28fbdf", async() => {
                BeginContext(1854, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\Dan\source\repos\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Details.cshtml"
                           WriteLiteral(Model.DeskQuote.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(1862, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1870, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd5a6e5b12844de9abf372a2dda5d3c", async() => {
                BeginContext(1892, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1908, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MegaDeskWebApp.Pages.MegaDesk.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDeskWebApp.Pages.MegaDesk.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDeskWebApp.Pages.MegaDesk.DetailsModel>)PageContext?.ViewData;
        public MegaDeskWebApp.Pages.MegaDesk.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
