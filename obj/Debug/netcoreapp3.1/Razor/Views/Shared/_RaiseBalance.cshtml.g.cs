#pragma checksum "d:\greenfox\ezsofi\week-07\day1\BankOfSimbaApp\Views\Shared\_RaiseBalance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d251764e1d907915d056adf5b45595d2760c22ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__RaiseBalance), @"mvc.1.0.view", @"/Views/Shared/_RaiseBalance.cshtml")]
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
#line 1 "d:\greenfox\ezsofi\week-07\day1\BankOfSimbaApp\Views\Shared\_RaiseBalance.cshtml"
using BankOfSimbaApp.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d251764e1d907915d056adf5b45595d2760c22ab", @"/Views/Shared/_RaiseBalance.cshtml")]
    public class Views_Shared__RaiseBalance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AccountsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "d:\greenfox\ezsofi\week-07\day1\BankOfSimbaApp\Views\Shared\_RaiseBalance.cshtml"
  
    var account = Model.Accounts;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<form action=\"raiseBalance\" method=\"post\">\r\n    <div>\r\n        <label for=\"Name\">Account Name</label>\r\n        <input type=\"text\" id=\"AccountName\" name=\"name\" required />\r\n    </div>\r\n\r\n    <input type=\"submit\" value=\"Raise Balance\" />\r\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591