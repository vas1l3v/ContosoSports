#pragma checksum "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Checkout\Complete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ac49e75a5eb3f52ca060d77feee17ea8a12877d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Complete), @"mvc.1.0.view", @"/Views/Checkout/Complete.cshtml")]
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
#line 1 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\_ViewImports.cshtml"
using Contoso.Apps.SportsLeague.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\_ViewImports.cshtml"
using Contoso.Apps.SportsLeague.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac49e75a5eb3f52ca060d77feee17ea8a12877d", @"/Views/Checkout/Complete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bf66ee1a5764bfdb85279aa9e375802bdc3af75", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_Complete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contoso.Apps.SportsLeague.Web.Models.OrderModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Checkout\Complete.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("HeaderOverlay", async() => {
                WriteLiteral("\r\n    <div class=\"button-wrapper\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <a href=\"#\" class=\"btn-content\">Order Completed</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            WriteLiteral("\r\n<section class=\"store\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"wrapper clearfix\">\r\n\r\n");
#nullable restore
#line 22 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Checkout\Complete.cshtml"
                 if (!string.IsNullOrWhiteSpace(Model.PaymentTransactionId))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""panel panel-success"">
                        <div class=""panel-heading"">
                            <h3 class=""panel-title"">Success!</h3>
                        </div>
                        <div class=""panel-body"">
                            <p>Thank you for your business! Your order has been completed. Here's your transaction Id for reference: <strong>");
#nullable restore
#line 29 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Checkout\Complete.cshtml"
                                                                                                                                        Write(Model.PaymentTransactionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                            <p><br /></p>\r\n                            <p><a");
            BeginWriteAttribute("href", " href=\"", 1083, "\"", 1118, 1);
#nullable restore
#line 31 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Checkout\Complete.cshtml"
WriteAttributeValue("", 1090, Url.Action("Index", "Home"), 1090, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn red-btn\">Return Home</a></p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 34 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Checkout\Complete.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""panel panel-warning"">
                        <div class=""panel-heading"">
                            <h3 class=""panel-title"">Payment has not been completed</h3>
                        </div>
                        <div class=""panel-body"">
                            <p>Oh no! I must've mistakenly brought you to this page. You have not completed your order yet...</p>
                            <p>Let's <a");
            BeginWriteAttribute("href", " href=\"", 1730, "\"", 1765, 1);
#nullable restore
#line 43 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Checkout\Complete.cshtml"
WriteAttributeValue("", 1737, Url.Action("Index", "Cart"), 1737, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color: blue\">take a look at your cart</a> and try again!</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 46 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Checkout\Complete.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contoso.Apps.SportsLeague.Web.Models.OrderModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
