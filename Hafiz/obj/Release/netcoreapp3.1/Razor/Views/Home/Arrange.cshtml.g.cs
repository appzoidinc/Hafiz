#pragma checksum "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Home\Arrange.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e89051adc3b8c6dc68bbf73f473071a64bc2f336"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Arrange), @"mvc.1.0.view", @"/Views/Home/Arrange.cshtml")]
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
#line 1 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\_ViewImports.cshtml"
using Hafiz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\_ViewImports.cshtml"
using Hafiz.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e89051adc3b8c6dc68bbf73f473071a64bc2f336", @"/Views/Home/Arrange.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c84f639b3dad500e35e127073d5615c51b73cf3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Arrange : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        function enableRange() {
            var range1 = document.getElementById(""fromRange"");
            var range2 = document.getElementById(""toRange"");
            range1.disabled = false;
            range2.disabled = false;
        }

        function disableRange() {
            var range1 = document.getElementById(""fromRange"");
            var range2 = document.getElementById(""toRange"");
            range1.disabled = true;
            range2.disabled = true;
        }
    </script>
");
            }
            );
            WriteLiteral("\r\n<h1>What do you want to arrange?</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e89051adc3b8c6dc68bbf73f473071a64bc2f3364316", async() => {
                WriteLiteral("\r\n    <div class=\"form-check\">\r\n        <select class=\"form-control\" id=\"surah\" name=\"surah\">\r\n");
#nullable restore
#line 25 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Home\Arrange.cshtml"
             for (int i = 0; i < Model.Length; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e89051adc3b8c6dc68bbf73f473071a64bc2f3364952", async() => {
#nullable restore
#line 27 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Home\Arrange.cshtml"
                                   Write(i+1);

#line default
#line hidden
#nullable disable
                    WriteLiteral(". ");
#nullable restore
#line 27 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Home\Arrange.cshtml"
                                          Write(Model[i]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Home\Arrange.cshtml"
                    WriteLiteral(i+1);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Home\Arrange.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </select>
        <div class=""form-check-inline"">
            <input class=""form-check-input"" type=""radio"" name=""type"" value=""1"" id=""typeEntire"" checked=""checked"" onclick=""disableRange()"" />
            <label class=""form-check-label"" for=""typeEntire"">Entire Surah</label>
        </div>
        <div class=""form-check-inline"">
            <input class=""form-check-input"" type=""radio"" name=""type"" value=""2"" id=""typeRange"" onclick=""enableRange()"" />
            <label class=""form-check-label"" for=""typeRange"">Ayaat Range</label><br />
        </div><br />

        <label class=""form-check-label"">For Ayaat Range option enter beginning and end ayat:</label>
        <input type=""number"" name=""fromRange"" id=""fromRange"" disabled=""disabled"" />
        <label class=""form-check-label"">To:</label>
        <input type=""number"" name=""toRange"" id=""toRange"" disabled=""disabled"" /><br />

        <input type=""submit"" class=""btn btn-primary"" />
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
