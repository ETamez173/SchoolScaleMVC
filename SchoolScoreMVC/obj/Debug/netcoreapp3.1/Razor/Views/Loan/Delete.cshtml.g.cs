#pragma checksum "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b0379ac63e652ffae597c8157f73b6ed610494b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loan_Delete), @"mvc.1.0.view", @"/Views/Loan/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b0379ac63e652ffae597c8157f73b6ed610494b", @"/Views/Loan/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c37122ec435b09d9eea4c2ba1ad1733e86fa79e", @"/Views/_ViewImports.cshtml")]
    public class Views_Loan_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolScoreMVC.Models.Loan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BCAIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Benefit Cost Analysis</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BenefitCostAnalysisRatio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BenefitCostAnalysisRatio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FutureCareerEarnings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("            ");
#nullable restore
#line 33 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Model.FutureCareerEarnings.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalSchoolCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("            ");
#nullable restore
#line 42 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Model.TotalSchoolCost.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CashPaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("            ");
#nullable restore
#line 50 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Model.CashPaid.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Grants));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("            ");
#nullable restore
#line 57 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Model.Grants.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Scholarships));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("            ");
#nullable restore
#line 64 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Model.Scholarships.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LoanAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("            ");
#nullable restore
#line 74 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Model.LoanAmount.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LoanRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 80 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LoanRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 84 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LoanLengthMonths));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 87 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LoanLengthMonths));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 90 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LoanLengthYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 93 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LoanLengthYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 96 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LoanPayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("\r\n            ");
#nullable restore
#line 102 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Model.LoanPayment.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalLoanPayments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("            ");
#nullable restore
#line 109 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Model.TotalLoanPayments.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 113 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalAmountPaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("            ");
#nullable restore
#line 117 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Model.TotalAmountPaid.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n");
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 140 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 143 "C:\Users\Owner\Source\Repos\SchoolScoreMVC\SchoolScoreMVC\Views\Loan\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b0379ac63e652ffae597c8157f73b6ed610494b14485", async() => {
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b0379ac63e652ffae597c8157f73b6ed610494b14833", async() => {
                    WriteLiteral("Back to List");
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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolScoreMVC.Models.Loan> Html { get; private set; }
    }
}
#pragma warning restore 1591