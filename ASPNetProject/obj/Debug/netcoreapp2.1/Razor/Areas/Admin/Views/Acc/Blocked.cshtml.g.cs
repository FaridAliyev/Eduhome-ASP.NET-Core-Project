#pragma checksum "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Blocked.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4824a1973353f0927b9cb41c4b004d9228c36d7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Acc_Blocked), @"mvc.1.0.view", @"/Areas/Admin/Views/Acc/Blocked.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Acc/Blocked.cshtml", typeof(AspNetCore.Areas_Admin_Views_Acc_Blocked))]
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
#line 1 "E:\Projects\ASPNetProject\Areas\Admin\Views\_ViewImports.cshtml"
using ASPNetProject.Models;

#line default
#line hidden
#line 2 "E:\Projects\ASPNetProject\Areas\Admin\Views\_ViewImports.cshtml"
using ASPNetProject.ViewModels;

#line default
#line hidden
#line 3 "E:\Projects\ASPNetProject\Areas\Admin\Views\_ViewImports.cshtml"
using ASPNetProject.Areas.Admin.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4824a1973353f0927b9cb41c4b004d9228c36d7b", @"/Areas/Admin/Views/Acc/Blocked.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fe69668118451dfbd039da4227812d30ccafe4e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Acc_Blocked : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Activate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-icon-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Blocked.cshtml"
  
    ViewData["Title"] = "Blocked Users";

#line default
#line hidden
            BeginContext(77, 351, true);
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-lg-12 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
                    <h4 class=""card-title"">User List</h4>
                    <p class=""card-description"">
                        Here you can see all blocked users
                    </p>
");
            EndContext();
#line 14 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Blocked.cshtml"
                     if (Model.Count() > 0)
                    {

#line default
#line hidden
            BeginContext(496, 1062, true);
            WriteLiteral(@"                        <div class=""table-responsive pt-3"">
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr>
                                        <th>
                                            Fullname
                                        </th>
                                        <th>
                                            Username
                                        </th>
                                        <th>
                                            Email
                                        </th>
                                        <th>
                                            Role
                                        </th>
                                        <th>
                                            Action
                                        </th>
                                    </tr>
                                </thead>
   ");
            WriteLiteral("                             <tbody>\r\n");
            EndContext();
#line 38 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Blocked.cshtml"
                                     foreach (UserVM item in Model)
                                    {

#line default
#line hidden
            BeginContext(1666, 144, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(1811, 23, false);
#line 42 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Blocked.cshtml"
                                           Write(item.Fullname.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(1834, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(1986, 13, false);
#line 45 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Blocked.cshtml"
                                           Write(item.Username);

#line default
#line hidden
            EndContext();
            BeginContext(1999, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2151, 10, false);
#line 48 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Blocked.cshtml"
                                           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2161, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2313, 9, false);
#line 51 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Blocked.cshtml"
                                           Write(item.Role);

#line default
#line hidden
            EndContext();
            BeginContext(2322, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2473, 498, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aff2d01594284bee9d47bfc805597c22", async() => {
                BeginContext(2514, 54, true);
                WriteLiteral("\r\n                                                    ");
                EndContext();
                BeginContext(2568, 346, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd53d6642cdc45e5843c042824cdd314", async() => {
                    BeginContext(2655, 173, true);
                    WriteLiteral("\r\n                                                        Activate\r\n                                                        <i class=\"mdi mdi-account-check btn-icon-append\">");
                    EndContext();
                    BeginContext(2829, 23, false);
#line 57 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Blocked.cshtml"
                                                                                                    Write(Html.AntiForgeryToken());

#line default
#line hidden
                    EndContext();
                    BeginContext(2852, 58, true);
                    WriteLiteral("</i>\r\n                                                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 55 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Blocked.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2914, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
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
            EndContext();
            BeginContext(2971, 100, true);
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 62 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Blocked.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3110, 112, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
            EndContext();
#line 66 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Blocked.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3294, 55, true);
            WriteLiteral("                        <h1>OOPS... Nothing here</h1>\r\n");
            EndContext();
#line 70 "E:\Projects\ASPNetProject\Areas\Admin\Views\Acc\Blocked.cshtml"
                    }

#line default
#line hidden
            BeginContext(3372, 74, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
