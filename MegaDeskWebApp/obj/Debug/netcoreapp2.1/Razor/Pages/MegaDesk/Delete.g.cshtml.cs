#pragma checksum "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdab284a4b59780a7bc7f98cd769bc97b892e621"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MegaDeskWebApp.Pages.MegaDesk.Pages_MegaDesk_Delete), @"mvc.1.0.razor-page", @"/Pages/MegaDesk/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/MegaDesk/Delete.cshtml", typeof(MegaDeskWebApp.Pages.MegaDesk.Pages_MegaDesk_Delete), null)]
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
#line 1 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\_ViewImports.cshtml"
using MegaDeskWebApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdab284a4b59780a7bc7f98cd769bc97b892e621", @"/Pages/MegaDesk/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"639e3b606a4580bcfed8657d0b3183f6646b0f72", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MegaDesk_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(101, 171, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Desk Quote</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(273, 54, false);
#line 16 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.CustName));

#line default
#line hidden
            EndContext();
            BeginContext(327, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(371, 50, false);
#line 19 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.CustName));

#line default
#line hidden
            EndContext();
            BeginContext(421, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(465, 55, false);
#line 22 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.DeskWidth));

#line default
#line hidden
            EndContext();
            BeginContext(520, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(564, 51, false);
#line 25 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.DeskWidth));

#line default
#line hidden
            EndContext();
            BeginContext(615, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(659, 55, false);
#line 28 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.DeskDepth));

#line default
#line hidden
            EndContext();
            BeginContext(714, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(758, 51, false);
#line 31 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.DeskDepth));

#line default
#line hidden
            EndContext();
            BeginContext(809, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(853, 57, false);
#line 34 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.DeskDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(910, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(954, 53, false);
#line 37 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.DeskDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(1007, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1051, 54, false);
#line 40 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Material));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1149, 50, false);
#line 43 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Material));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1243, 54, false);
#line 46 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.RushDays));

#line default
#line hidden
            EndContext();
            BeginContext(1297, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1341, 50, false);
#line 49 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.RushDays));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1435, 59, false);
#line 52 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.DeskQuoteDate));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1538, 55, false);
#line 55 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.DeskQuoteDate));

#line default
#line hidden
            EndContext();
            BeginContext(1593, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1637, 60, false);
#line 58 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.DeskQuoteTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1697, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1741, 56, false);
#line 61 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.DeskQuoteTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1797, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1835, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ddf6ba867ae449195f9c3ad7fe71e55", async() => {
                BeginContext(1855, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1865, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cc2a6130b8b8405488089aedb5562640", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 66 "C:\Users\Bryce\Documents\School Stuff\6th Year\2nd Semester\CIT 365\MegaDeskWebApp\MegaDeskWebApp\Pages\MegaDesk\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DeskQuote.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1911, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1995, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddd7b699055f46b2b5e4d1ebdf16a4d1", async() => {
                    BeginContext(2018, 12, true);
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
                BeginContext(2034, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2047, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MegaDeskWebApp.Pages.MegaDesk.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDeskWebApp.Pages.MegaDesk.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDeskWebApp.Pages.MegaDesk.DeleteModel>)PageContext?.ViewData;
        public MegaDeskWebApp.Pages.MegaDesk.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
