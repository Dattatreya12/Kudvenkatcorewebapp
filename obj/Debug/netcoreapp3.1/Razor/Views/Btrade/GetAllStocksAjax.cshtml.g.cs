#pragma checksum "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\Btrade\GetAllStocksAjax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96414f22ddfc29448ca0ffde5be22bf24d677e78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Btrade_GetAllStocksAjax), @"mvc.1.0.view", @"/Views/Btrade/GetAllStocksAjax.cshtml")]
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
#line 1 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Kudvenkatcorewebapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Kudvenkatcorewebapp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Kudvenkatcorewebapp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Kudvenkatcorewebapp.Models.Trade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Kudvenkatcorewebapp.ViewModels.Trade;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96414f22ddfc29448ca0ffde5be22bf24d677e78", @"/Views/Btrade/GetAllStocksAjax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ba9eb9fbf7f890246b7991df0aa86b0dfdac00", @"/Views/_ViewImports.cshtml")]
    public class Views_Btrade_GetAllStocksAjax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tradeinformation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShareCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Btrade", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-success m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Allstocinformation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\Btrade\GetAllStocksAjax.cshtml"
 if (@ViewBag.message == 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""alert alert-warning alert-dismissible fade show"" role=""alert"">
        <strong>Good!</strong> Successfully Inserted Your Data.
        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
");
#nullable restore
#line 16 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\Btrade\GetAllStocksAjax.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96414f22ddfc29448ca0ffde5be22bf24d677e786080", async() => {
                WriteLiteral("Create New Stock");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</p>

<table class=""table table-striped text-sm-center font-weight-bold mx-auto"">
    <thead class=""bg-info text-white"">
        <tr>
            <th>SL NO</th>
            <th>ID</th>
            <th>Stockname</th>
            <th>Stockbuykprice</th>
            <th>Stocksellprice</th>
            <th>Stocktotalshares</th>
            <th>Stock purchased date</th>
            <th>Stock sell date</th>
            <th>Total Invested Amount</th>
            <th>Broker Name</th>
            <th>Actions</th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 37 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\Btrade\GetAllStocksAjax.cshtml"
         foreach (var item in Model.Select((x, i) => new { data = x, Index = i }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 1310, "\"", 1331, 2);
            WriteAttributeValue("", 1315, "TR_", 1315, 3, true);
#nullable restore
#line 39 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\Btrade\GetAllStocksAjax.cshtml"
WriteAttributeValue("", 1318, item.data.Id, 1318, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\Btrade\GetAllStocksAjax.cshtml"
                Write( ((Int32)1) + item.Index );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n               \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "96414f22ddfc29448ca0ffde5be22bf24d677e789195", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 44 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\Btrade\GetAllStocksAjax.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.data;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 46 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\Btrade\GetAllStocksAjax.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>

    <tfoot class=""bg-info text-white"">
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td>");
#nullable restore
#line 59 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\Btrade\GetAllStocksAjax.cshtml"
           Write(Model.Sum(i => i.TotalInvestedAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 68 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\Btrade\GetAllStocksAjax.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script>
    function deleteItem(form) {
        var RemoveItem1 = $(form);
        RemoveItem1.closest(""tr"").remove();
    }

    function ShowDetailForm() {
        $(""#DivDetailView"").addClass(""visible"");
        $(""#DivDetailView"").removeClass(""invisible"");

        $(""#DivListView"").addClass(""invisible"");
        $(""#DivListView"").removeClass(""visible"");
        return;
    }

    function CloseDetailForm() {
        $(""#DivDetailView"").addClass(""invisible"");
        $(""#DivDetailView"").removeClass(""visible"");

        $(""#DivListView"").addClass(""visible"");
        $(""#DivListView"").removeClass(""invisible"");
        return;
    }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tradeinformation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
