#pragma checksum "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af4a30c6b0f0676fbf76b03d76d5b76212353e52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Detail), @"mvc.1.0.view", @"/Views/Employee/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Detail.cshtml", typeof(AspNetCore.Views_Employee_Detail))]
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
#line 1 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\_ViewImports.cshtml"
using Paycompute;

#line default
#line hidden
#line 2 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\_ViewImports.cshtml"
using Paycompute.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af4a30c6b0f0676fbf76b03d76d5b76212353e52", @"/Views/Employee/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d82a17a92ca28dc354efe5ab80300d7aa4b038b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 269, true);
            WriteLiteral(@"
    <div class=""col-md-12 grid-margin grid-margin-md-0"">
        <div class=""card"">
            <div class=""card-body"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">");
            EndContext();
            BeginContext(301, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af4a30c6b0f0676fbf76b03d76d5b76212353e524095", async() => {
                BeginContext(345, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(353, 59, true);
            WriteLiteral("</li>\r\n                        <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(412, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af4a30c6b0f0676fbf76b03d76d5b76212353e525728", async() => {
                BeginContext(434, 13, true);
                WriteLiteral("Employee List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(451, 364, true);
            WriteLiteral(@"</li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Employee Details</li>
                    </ol>
                </nav><br /><br />
                <div class=""wrap d-flex justify-content-start justify-content-sm-center flex-wrap"">
                    <img class=""rounded-circle shadow-lg"" style=""width:300px; height:350px""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 815, "\"", 849, 1);
#line 14 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 821, Url.Content(Model.ImageUrl), 821, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(850, 164, true);
            WriteLiteral(" alt=\"\" />\r\n                    <div class=\"wrap align-items-center ml-5\">\r\n                        <p class=\"font-weight-bold text-success\" style=\"font-size:20px\">");
            EndContext();
            BeginContext(1015, 14, false);
#line 16 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml"
                                                                                   Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1029, 67, true);
            WriteLiteral("</p>\r\n                        <p class=\"font-weight-normal\"> Role: ");
            EndContext();
            BeginContext(1097, 17, false);
#line 17 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml"
                                                        Write(Model.Designation);

#line default
#line hidden
            EndContext();
            BeginContext(1114, 69, true);
            WriteLiteral("</p>\r\n                        <p class=\"font-weight-normal\"> Gender: ");
            EndContext();
            BeginContext(1184, 12, false);
#line 18 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml"
                                                          Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(1196, 75, true);
            WriteLiteral("</p>\r\n                        <p class=\"font-weight-normal\">Date Of Birth: ");
            EndContext();
            BeginContext(1272, 32, false);
#line 19 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml"
                                                                Write(Model.DOB.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 77, true);
            WriteLiteral("</p>\r\n                        <p class=\"font-weight-normal\">Employee Number: ");
            EndContext();
            BeginContext(1382, 16, false);
#line 20 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml"
                                                                  Write(Model.EmployeeNo);

#line default
#line hidden
            EndContext();
            BeginContext(1398, 71, true);
            WriteLiteral("</p>\r\n                        <p class=\"font-weight-normal\">NI Number: ");
            EndContext();
            BeginContext(1470, 25, false);
#line 21 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml"
                                                            Write(Model.NationalInsuranceNo);

#line default
#line hidden
            EndContext();
            BeginContext(1495, 79, true);
            WriteLiteral("</p>\r\n                        <p class=\"font-weight-normal\">Email: <a href=\"#\">");
            EndContext();
            BeginContext(1575, 11, false);
#line 22 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml"
                                                                    Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1586, 73, true);
            WriteLiteral("</a></p>\r\n                        <p class=\"font-weight-normal\">Phone: <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1659, "\"", 1682, 2);
            WriteAttributeValue("", 1666, "tel:", 1666, 4, true);
#line 23 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 1670, Model.Phone, 1670, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1683, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1685, 11, false);
#line 23 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml"
                                                                                   Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1696, 259, true);
            WriteLiteral(@"</a></p>
                        <br /><br />
                        <p class=""font-weight-bold""> Pay & Deductions</p>
                        <hr style=""background-color:crimson"" />
                        <p class=""font-weight-normal""> Payment Method: ");
            EndContext();
            BeginContext(1956, 19, false);
#line 27 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml"
                                                                  Write(Model.PaymentMethod);

#line default
#line hidden
            EndContext();
            BeginContext(1975, 75, true);
            WriteLiteral("</p>\r\n                        <p class=\"font-weight-normal\"> Student Loan: ");
            EndContext();
            BeginContext(2051, 17, false);
#line 28 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml"
                                                                Write(Model.StudentLoan);

#line default
#line hidden
            EndContext();
            BeginContext(2068, 75, true);
            WriteLiteral("</p>\r\n                        <p class=\"font-weight-normal\"> Union Member: ");
            EndContext();
            BeginContext(2144, 17, false);
#line 29 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml"
                                                                Write(Model.UnionMember);

#line default
#line hidden
            EndContext();
            BeginContext(2161, 143, true);
            WriteLiteral("</p>\r\n                        <p class=\"font-weight-normal\"><i class=\"fas fa-envelope\" style=\"margin-right:0.6em; color:cornflowerblue\"></i> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2304, "\"", 2383, 7);
            WriteAttributeValue("", 2311, "mailto:", 2311, 7, true);
#line 30 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 2318, Model.Email, 2318, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2330, "?subject=Payslip&body=Attached", 2330, 30, true);
            WriteAttributeValue(" ", 2360, "within", 2361, 7, true);
            WriteAttributeValue(" ", 2367, "is", 2368, 3, true);
            WriteAttributeValue(" ", 2370, "your", 2371, 5, true);
            WriteAttributeValue(" ", 2375, "paylip.", 2376, 8, true);
            EndWriteAttribute();
            BeginContext(2384, 249, true);
            WriteLiteral(">Send Payslip</a></p>\r\n                        <br /><br />\r\n\r\n                        <p class=\"font-weight-bold\"> Address</p>\r\n                        <hr style=\"background-color:crimson\" />\r\n                        <p class=\"font-weight-normal\"> ");
            EndContext();
            BeginContext(2634, 13, false);
#line 35 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml"
                                                  Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2647, 61, true);
            WriteLiteral("</p>\r\n                        <p class=\"font-weight-normal\"> ");
            EndContext();
            BeginContext(2709, 10, false);
#line 36 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml"
                                                  Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(2719, 61, true);
            WriteLiteral("</p>\r\n                        <p class=\"font-weight-normal\"> ");
            EndContext();
            BeginContext(2781, 14, false);
#line 37 "G:\C# projects\PayCompute Enterprise App\Paycompute\Views\Employee\Detail.cshtml"
                                                  Write(Model.Postcode);

#line default
#line hidden
            EndContext();
            BeginContext(2795, 170, true);
            WriteLiteral("</p>\r\n                        <br />\r\n                        <br />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
