#pragma checksum "C:\Users\DAttatreya\OneDrive\Desktop\Downloads\Kudvenkatcorewebapp\Kudvenkatcorewebapp\Views\Shared\_StocksnformationView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4715b42890bdde3dc1158fb1dc5ec5533882c86d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__StocksnformationView), @"mvc.1.0.view", @"/Views/Shared/_StocksnformationView.cshtml")]
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
#line 1 "C:\Users\DAttatreya\OneDrive\Desktop\Downloads\Kudvenkatcorewebapp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Kudvenkatcorewebapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DAttatreya\OneDrive\Desktop\Downloads\Kudvenkatcorewebapp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Kudvenkatcorewebapp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DAttatreya\OneDrive\Desktop\Downloads\Kudvenkatcorewebapp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Kudvenkatcorewebapp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DAttatreya\OneDrive\Desktop\Downloads\Kudvenkatcorewebapp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DAttatreya\OneDrive\Desktop\Downloads\Kudvenkatcorewebapp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Kudvenkatcorewebapp.Models.Trade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DAttatreya\OneDrive\Desktop\Downloads\Kudvenkatcorewebapp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Kudvenkatcorewebapp.ViewModels.Trade;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4715b42890bdde3dc1158fb1dc5ec5533882c86d", @"/Views/Shared/_StocksnformationView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ba9eb9fbf7f890246b7991df0aa86b0dfdac00", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__StocksnformationView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BrokerTradeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n<div class=\"col-12\">\r\n    <table class=\"table table-striped\">\r\n        <tr class=\"  bg-info text-black\">\r\n");
            WriteLiteral("            <th>Stock Name</th>\r\n            <th>Stocktotalshares</th>\r\n            <th>Stockbuykprice</th>\r\n            <th>Stocksellprice</th>\r\n            <th>Actions</th>\r\n        </tr>\r\n");
#nullable restore
#line 18 "C:\Users\DAttatreya\OneDrive\Desktop\Downloads\Kudvenkatcorewebapp\Kudvenkatcorewebapp\Views\Shared\_StocksnformationView.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n");
            WriteLiteral("        <td>");
#nullable restore
#line 22 "C:\Users\DAttatreya\OneDrive\Desktop\Downloads\Kudvenkatcorewebapp\Kudvenkatcorewebapp\Views\Shared\_StocksnformationView.cshtml"
       Write(item.tradeinformation.Stockname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\DAttatreya\OneDrive\Desktop\Downloads\Kudvenkatcorewebapp\Kudvenkatcorewebapp\Views\Shared\_StocksnformationView.cshtml"
       Write(item.tradeinformation.Stocktotalshares);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "C:\Users\DAttatreya\OneDrive\Desktop\Downloads\Kudvenkatcorewebapp\Kudvenkatcorewebapp\Views\Shared\_StocksnformationView.cshtml"
       Write(item.tradeinformation.Stockbuykprice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 25 "C:\Users\DAttatreya\OneDrive\Desktop\Downloads\Kudvenkatcorewebapp\Kudvenkatcorewebapp\Views\Shared\_StocksnformationView.cshtml"
       Write(item.tradeinformation.Stocksellprice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>Actions</td>\r\n    </tr>\r\n");
#nullable restore
#line 28 "C:\Users\DAttatreya\OneDrive\Desktop\Downloads\Kudvenkatcorewebapp\Kudvenkatcorewebapp\Views\Shared\_StocksnformationView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BrokerTradeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
