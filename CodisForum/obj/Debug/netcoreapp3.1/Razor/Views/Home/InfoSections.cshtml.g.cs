#pragma checksum "C:\Users\Usman Tahir\source\repos\CodisForum\CodisForum\Views\Home\InfoSections.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e416c8460b56e01c412add38dfa2e2f375393605"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_InfoSections), @"mvc.1.0.view", @"/Views/Home/InfoSections.cshtml")]
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
#line 1 "C:\Users\Usman Tahir\source\repos\CodisForum\CodisForum\Views\_ViewImports.cshtml"
using CodisForum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usman Tahir\source\repos\CodisForum\CodisForum\Views\_ViewImports.cshtml"
using CodisForum.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e416c8460b56e01c412add38dfa2e2f375393605", @"/Views/Home/InfoSections.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2431b8c3dcc2942b26826d4dddf96355f4e7e148", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_InfoSections : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Male", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Female", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Usman Tahir\source\repos\CodisForum\CodisForum\Views\Home\InfoSections.cshtml"
  
    ViewData["Title"] = "Info Section";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mt-5"">
    <div class=""col-md-12 mx-auto"">
        <div id=""smartwizard"">
            <ul class=""nav"">
                <li>
                    <a class=""nav-link"" href=""#step-1"">
                        Step 1
                    </a>
                </li>
                <li>
                    <a class=""nav-link"" href=""#step-2"">
                        Step 2
                    </a>
                </li>
                <li>
                    <a class=""nav-link"" href=""#step-3"">
                        Step 3
                    </a>
                </li>
            </ul>

            <div class=""tab-content"">
                <div id=""step-1"" class=""tab-pane"" role=""tabpanel"">
                    <h2 class=""text-center pt-3"">Basic Information</h2>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e416c8460b56e01c412add38dfa2e2f3753936055676", async() => {
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n                                <label>First Name</label>\r\n                                <input type=\"text\" name=\"fname\"");
                BeginWriteAttribute("value", " value=\"", 1247, "\"", 1255, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter First Name"" class=""form-control"" />
                            </div>
                            <div class=""col-md-6"">
                                <label>Last Name</label>
                                <input type=""text"" name=""lname""");
                BeginWriteAttribute("value", " value=\"", 1522, "\"", 1530, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter Last Name"" class=""form-control"" />
                            </div>
                        </div>

                        <div class=""row pt-2"">
                            <div class=""col-md-6"">
                                <label>Age</label>
                                <input type=""date"" name=""age""");
                BeginWriteAttribute("value", " value=\"", 1870, "\"", 1878, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""dd/mm/yyyy"" class=""form-control"" />
                            </div>
                            <div class=""col-md-6"">
                                <label>Gender</label>
                                <select class=""form-control"" name=""gender"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e416c8460b56e01c412add38dfa2e2f3753936057574", async() => {
                    WriteLiteral("Select Gender");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e416c8460b56e01c412add38dfa2e2f3753936058954", async() => {
                    WriteLiteral("Male");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e416c8460b56e01c412add38dfa2e2f37539360510211", async() => {
                    WriteLiteral("Female");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                            </div>
                        </div>

                        <div class=""row pt-2"">
                            <div class=""col-md-6"">
                                <label>Cnic</label>
                                <input type=""number"" name=""cnic""");
                BeginWriteAttribute("value", " value=\"", 2705, "\"", 2713, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""xxxxxxxxxxxxx"" class=""form-control"" />
                            </div>
                            <div class=""col-md-6"">
                                <label>Phone Number</label>
                                <input type=""number"" name=""ph""");
                BeginWriteAttribute("value", " value=\"", 2979, "\"", 2987, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter Phone Number"" class=""form-control"" />
                            </div>
                        </div>

                        <div class=""row pt-2"">
                            <div class=""col-md-6"">
                                <label>Country</label>
                                <input type=""text"" name=""country""");
                BeginWriteAttribute("value", " value=\"", 3338, "\"", 3346, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter Country"" class=""form-control"" />
                            </div>
                            <div class=""col-md-6"">
                                <label>District</label>
                                <input type=""text"" name=""district""");
                BeginWriteAttribute("value", " value=\"", 3612, "\"", 3620, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter District\" class=\"form-control\" />\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div id=\"step-2\" class=\"tab-pane\" role=\"tabpanel\">\r\n                    <h2 class=\"text-center pt-3\">Acedmic Information</h2>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e416c8460b56e01c412add38dfa2e2f37539360514913", async() => {
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-12\">\r\n                                <label>School/College/University</label>\r\n                                <input type=\"text\" name=\"fname\"");
                BeginWriteAttribute("value", " value=\"", 4226, "\"", 4234, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter School/College/University"" class=""form-control"" />
                            </div>
                        </div>

                        <div class=""row pt-2"">
                            <div class=""col-md-12"">
                                <label>Degree</label>
                                <input type=""text"" name=""degree""");
                BeginWriteAttribute("value", " value=\"", 4597, "\"", 4605, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter Degree"" class=""form-control"" />
                            </div>
                        </div>

                        <div class=""row pt-2"">
                            <div class=""col-md-12"">
                                <label>Specialization</label>
                                <input type=""text"" name=""specialization""");
                BeginWriteAttribute("value", " value=\"", 4965, "\"", 4973, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter Specialization"" class=""form-control"" />
                            </div>
                        </div>

                        <div class=""row pt-2"">
                            <div class=""col-md-6"">
                                <label>Start Year</label>
                                <input type=""date"" name=""styear""");
                BeginWriteAttribute("value", " value=\"", 5328, "\"", 5336, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter Start Year"" class=""form-control"" />
                            </div>
                            <div class=""col-md-6"">
                                <label>End Year</label>
                                <input type=""date"" name=""edyear""");
                BeginWriteAttribute("value", " value=\"", 5603, "\"", 5611, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter End Year\" class=\"form-control\" />\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div id=\"step-3\" class=\"tab-pane\" role=\"tabpanel\">\r\n                    <h2 class=\"text-center pt-3\">Working Domain</h2>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e416c8460b56e01c412add38dfa2e2f37539360519185", async() => {
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n                                <label>Job Title</label>\r\n                                <input type=\"text\" name=\"job_title\"");
                BeginWriteAttribute("value", " value=\"", 6199, "\"", 6207, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter School/College/University"" class=""form-control"" />
                            </div>
                            <div class=""col-md-6"">
                                <label>Experience year</label>
                                <input type=""text"" name=""exp_year""");
                BeginWriteAttribute("value", " value=\"", 6498, "\"", 6506, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter School/College/University"" class=""form-control"" />
                            </div>
                        </div>

                        <div class=""row pt-2"">
                            <div class=""col-md-12"">
                                <label>Other Skills</label>
                                <input type=""text"" name=""degree""");
                BeginWriteAttribute("value", " value=\"", 6875, "\"", 6883, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter Degree"" class=""form-control"" />
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <button class=""btn btn-primary mt-2"" type=""submit"">Submit</button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
