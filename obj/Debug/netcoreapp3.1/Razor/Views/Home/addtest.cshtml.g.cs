#pragma checksum "c:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\MyTestingWebApp\Views\Home\addtest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6993fc05ac2359ec7452eb7d0082013bab49f3f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_addtest), @"mvc.1.0.view", @"/Views/Home/addtest.cshtml")]
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
#line 1 "c:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\MyTestingWebApp\Views\_ViewImports.cshtml"
using MyTestingWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\MyTestingWebApp\Views\_ViewImports.cshtml"
using MyTestingWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6993fc05ac2359ec7452eb7d0082013bab49f3f9", @"/Views/Home/addtest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e06160136314e2c4edb1598b292d42cf3a8820c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_addtest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("insertest"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "c:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\MyTestingWebApp\Views\Home\addtest.cshtml"
  
    ViewData["Title"] = "AddTest";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <h1 class=\"display-4\">Welcome this is first add test form</h1>\r\n    <hr>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6993fc05ac2359ec7452eb7d0082013bab49f3f94264", async() => {
                WriteLiteral(@"
    
    <div class=""form-group"">
        <label for=""testtitle"">Test Title</label>
        <input  type=""text"" class=""form-control"" id=""testtitle"" aria-describedby=""testtitleHelp"" placeholder=""Enter Test Title"" name=""testname"">
        <small id=""testtitleHelp"" class=""form-text text-muted"">We'll never share your email with anyone else.</small>
    </div>
    
    <div class=""form-group"">
        <label for=""testtype"">Test Type</label>
        <input  type=""text"" class=""form-control"" id=""testtype"" aria-describedby=""testtypeHelp"" placeholder=""Enter Test Type"" name=""testtype"">
        <small id=""testtypeHelp"" class=""form-text text-muted"">We'll never share your email with anyone else.</small>
    </div>

    <div class=""form-group"">
        <label for=""testxpath1"">Element Xpath1</label>
        <input  type=""text"" class=""form-control"" id=""testxpath1"" aria-describedby=""testxpath1Help"" placeholder=""Enter Test Xpath1"" name=""testxpath1"">
        <small id=""testxpath1Help"" class=""form-text text-mute");
                WriteLiteral(@"d"">We'll never share your email with anyone else.</small>
    </div>

    <div class=""form-group"">
        <label for=""testxpath2"">Element Xpath2</label>
        <input  type=""text"" class=""form-control"" id=""testxpath2"" aria-describedby=""testxpath2Help"" placeholder=""Enter Test Xpath2"" name=""testxpath2"">
        <small id=""testxpath2Help"" class=""form-text text-muted"">We'll never share your email with anyone else.</small>
    </div>

    <div class=""form-group"">
        <label for=""teststatus"">Test Status</label>
        <input  type=""text"" class=""form-control"" id=""teststatus"" aria-describedby=""testxpath2Help"" placeholder=""Enter Test Status"" name=""teststatus"">
        <small id=""teststatus"" class=""form-text text-muted"">We'll never share your email with anyone else.</small>
    </div>

    <button type=""submit"" class=""btn btn-primary pull-left"">Submit</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n\r\n");
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