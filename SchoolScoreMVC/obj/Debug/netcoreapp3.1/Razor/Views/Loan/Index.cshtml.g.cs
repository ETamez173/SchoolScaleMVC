#pragma checksum "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e39fd41d3d10ad9d240da96d3b5f669cd0c43be1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loan_Index), @"mvc.1.0.view", @"/Views/Loan/Index.cshtml")]
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
#line 1 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\_ViewImports.cshtml"
using SchoolScoreMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\_ViewImports.cshtml"
using SchoolScoreMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e39fd41d3d10ad9d240da96d3b5f669cd0c43be1", @"/Views/Loan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c37122ec435b09d9eea4c2ba1ad1733e86fa79e", @"/Views/_ViewImports.cshtml")]
    public class Views_Loan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SchoolScoreMVC.Models.Loan>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>Financial Workbench</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e39fd41d3d10ad9d240da96d3b5f669cd0c43be13700", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LoanAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LoanRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LoanLengthMonths));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LoanLengthYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LoanPayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalLoanPayments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CashPaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Grants));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Scholarships));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalAmountPaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FutureCareerEarnings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BenefitCostAnalysisRatio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 64 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoanAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoanRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoanLengthMonths));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoanLengthYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoanPayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalLoanPayments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CashPaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Grants));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Scholarships));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalAmountPaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FutureCareerEarnings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BenefitCostAnalysisRatio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("        <td>\r\n            ");
#nullable restore
#line 112 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
       Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            ");
#nullable restore
#line 113 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
       Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            ");
#nullable restore
#line 114 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
       Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n        </td>\r\n        </tr>\r\n");
#nullable restore
#line 117 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SchoolScoreMVC.Models.Loan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
