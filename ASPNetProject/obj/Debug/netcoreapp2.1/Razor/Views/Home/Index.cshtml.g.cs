#pragma checksum "E:\Projects\ASPNetProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed01d611fd3abeba2ca8c31e8bc6e85abb6c011e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "E:\Projects\ASPNetProject\Views\_ViewImports.cshtml"
using ASPNetProject.Models;

#line default
#line hidden
#line 2 "E:\Projects\ASPNetProject\Views\_ViewImports.cshtml"
using ASPNetProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed01d611fd3abeba2ca8c31e8bc6e85abb6c011e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75ad261125fd47f9d3a83db31753885bdcad958", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("default-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(55, 144, true);
            WriteLiteral("\r\n<!-- Background Area Start -->\r\n<section id=\"slider-container\" class=\"slider-area two\">\r\n    <div class=\"slider-owl owl-theme owl-carousel\">\r\n");
            EndContext();
#line 9 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
         foreach (Slider item in Model.Sliders)
        {

#line default
#line hidden
            BeginContext(259, 84, true);
            WriteLiteral("            <!-- Start Slingle Slide -->\r\n            <div class=\"single-slide item\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 343, "\"", 416, 4);
            WriteAttributeValue("", 351, "background-image:", 351, 17, true);
            WriteAttributeValue(" ", 368, "url(\'", 369, 6, true);
#line 12 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 374, Url.Content("~/img/slider/"+item.Image), 374, 40, false);

#line default
#line hidden
            WriteAttributeValue("", 414, "\')", 414, 2, true);
            EndWriteAttribute();
            BeginContext(417, 448, true);
            WriteLiteral(@">
                <!-- Start Slider Content -->
                <div class=""slider-content-area"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-md-10 col-md-offset-1"">
                                <div class=""slide-content-wrapper"">
                                    <div class=""slide-content text-center"">
                                        <h2>");
            EndContext();
            BeginContext(866, 19, false);
#line 20 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                       Write(Model.Content.Title);

#line default
#line hidden
            EndContext();
            BeginContext(885, 51, true);
            WriteLiteral(" </h2>\r\n                                        <p>");
            EndContext();
            BeginContext(937, 25, false);
#line 21 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                      Write(Model.Content.Description);

#line default
#line hidden
            EndContext();
            BeginContext(962, 46, true);
            WriteLiteral("</p>\r\n                                        ");
            EndContext();
            BeginContext(1008, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "707cf93863e44049ba1fae38e27ac405", async() => {
                BeginContext(1073, 10, true);
                WriteLiteral("Learn more");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1087, 313, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Start Slider Content -->
            </div>
            <!-- End Slingle Slide -->
");
            EndContext();
#line 32 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1411, 180, true);
            WriteLiteral("    </div>\r\n</section>\r\n<!-- Background Area End -->\r\n<!-- Service Start -->\r\n<div class=\"service-area two pt-150 pb-150\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 40 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
             foreach (Service item in Model.Services)
            {

#line default
#line hidden
            BeginContext(1661, 137, true);
            WriteLiteral("                <div class=\"col-md-4 col-sm-4 col-xs-12\">\r\n                    <div class=\"single-service\">\r\n                        <h3>");
            EndContext();
            BeginContext(1798, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc3f196121ec4fc7ac68a4145dab859c", async() => {
                BeginContext(1846, 9, false);
#line 44 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                                                      Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1859, 34, true);
            WriteLiteral("</h3>\r\n                        <p>");
            EndContext();
            BeginContext(1894, 16, false);
#line 45 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                      Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1910, 59, true);
            WriteLiteral(" </p>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 48 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1984, 300, true);
            WriteLiteral(@"        </div>
    </div>
</div>
<!-- Service End -->
<!-- About Start -->
<div class=""about-area pb-155"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6"">
                <div class=""about-content"">
                    <h2>WELCOME TO <span>");
            EndContext();
            BeginContext(2285, 16, false);
#line 59 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                    Write(Model.About.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2301, 37, true);
            WriteLiteral("</span></h2>\r\n                    <p>");
            EndContext();
            BeginContext(2339, 23, false);
#line 60 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                  Write(Model.About.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2362, 47, true);
            WriteLiteral("</p>\r\n                    <p class=\"hidden-sm\">");
            EndContext();
            BeginContext(2410, 23, false);
#line 61 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                    Write(Model.About.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2433, 26, true);
            WriteLiteral("</p>\r\n                    ");
            EndContext();
            BeginContext(2459, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "780b11aaeed44ba3bbc2ddea04db7274", async() => {
                BeginContext(2525, 12, true);
                WriteLiteral("view courses");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2541, 156, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6 col-sm-6\">\r\n                <div class=\"about-img\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2697, "\"", 2731, 2);
            WriteAttributeValue("", 2703, "img/about/", 2703, 10, true);
#line 67 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 2713, Model.About.Image, 2713, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2732, 561, true);
            WriteLiteral(@" alt=""about"">
                </div>
            </div>
        </div>
    </div>
</div>
<!-- About End -->
<!-- Courses Area Start -->
<div class=""courses-area two pt-150 pb-150 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    <img src=""img/icon/section1.png"" alt=""section-title"">
                    <h2>COURSES WE OFFER</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            ");
            EndContext();
            BeginContext(3294, 41, false);
#line 86 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
       Write(await  Component.InvokeAsync("Courses",3));

#line default
#line hidden
            EndContext();
            BeginContext(3335, 400, true);
            WriteLiteral(@"  
        </div>
    </div>
</div>
<!-- Courses Area End -->
<!-- Notice Start -->
<section class=""notice-area two pt-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-right-wrapper mb-25 pb-25"">
                    <h3>TAKE A VIDEO TOUR</h3>
                    <div class=""notice-video""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3735, "\"", 3826, 4);
            WriteAttributeValue("", 3743, "background-image:", 3743, 17, true);
            WriteAttributeValue(" ", 3760, "url(\'", 3761, 6, true);
#line 98 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 3766, Url.Content("~/img/notice/"+Model.Video.Source), 3766, 48, false);

#line default
#line hidden
            WriteAttributeValue("", 3814, "\')!important", 3814, 12, true);
            EndWriteAttribute();
            BeginContext(3827, 567, true);
            WriteLiteral(@">
                        <div class=""video-icon video-hover"">
                            <a class=""video-popup"" href=""https://www.youtube.com/watch?v=to6Ghf8UL7o"">
                                <i class=""zmdi zmdi-play""></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-left-wrapper"">
                    <h3>notice board</h3>
                    <div class=""notice-left"">
");
            EndContext();
#line 111 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                         foreach (NoticeBoard item in Model.NoticeBoards)
                        {

#line default
#line hidden
            BeginContext(4496, 110, true);
            WriteLiteral("                            <div class=\"single-notice-left mb-23 pb-20\">\r\n                                <h4>");
            EndContext();
            BeginContext(4607, 9, false);
#line 114 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                               Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(4616, 42, true);
            WriteLiteral("</h4>\r\n                                <p>");
            EndContext();
            BeginContext(4659, 16, false);
#line 115 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(4675, 42, true);
            WriteLiteral("</p>\r\n                            </div>\r\n");
            EndContext();
#line 117 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4744, 561, true);
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Notice End -->
<!-- Event Area Start -->
<div class=""event-area two text-center pt-100 pb-145"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    <img src=""img/icon/section.png"" alt=""section-title"">
                    <h2>UPCOMING EVENTS</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
");
            EndContext();
#line 137 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
             foreach (Event item in Model.Events)
            {

#line default
#line hidden
            BeginContext(5371, 191, true);
            WriteLiteral("                <div class=\"col-md-6 col-sm-12 col-xs-12\">\r\n                    <div class=\"single-event mb-35\">\r\n                        <div class=\"event-img\">\r\n                            ");
            EndContext();
            BeginContext(5562, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd00ffedad554f148082f8cee3d2f418", async() => {
                BeginContext(5633, 4, true);
                WriteLiteral("<img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5637, "\"", 5664, 2);
                WriteAttributeValue("", 5643, "img/event/", 5643, 10, true);
#line 142 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 5653, item.Image, 5653, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5665, 48, true);
                WriteLiteral(" alt=\"event\" style=\"width:210px; height:210px;\">");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 142 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5717, 129, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"event-content text-left\">\r\n                            <h3>");
            EndContext();
            BeginContext(5847, 9, false);
#line 145 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                           Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(5856, 39, true);
            WriteLiteral("</h3>\r\n                            <h4>");
            EndContext();
            BeginContext(5895, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f03e920ed6d44304bfbf19e912dd0011", async() => {
                BeginContext(5967, 9, false);
#line 146 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                                                                                  Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 146 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5980, 106, true);
            WriteLiteral("</h4>\r\n                            <ul>\r\n                                <li><i class=\"fa fa-clock-o\"></i>");
            EndContext();
            BeginContext(6087, 9, false);
#line 148 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                                            Write(item.Time);

#line default
#line hidden
            EndContext();
            BeginContext(6096, 75, true);
            WriteLiteral("</li>\r\n                                <li><i class=\"fa fa-map-marker\"></i>");
            EndContext();
            BeginContext(6172, 10, false);
#line 149 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                                               Write(item.Venue);

#line default
#line hidden
            EndContext();
            BeginContext(6182, 137, true);
            WriteLiteral("</li>\r\n                            </ul>\r\n                            <div class=\"event-content-right\">\r\n                                ");
            EndContext();
            BeginContext(6319, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71440b934f184f04b6c6b595cfb5f418", async() => {
                BeginContext(6410, 8, true);
                WriteLiteral("join now");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 152 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6422, 122, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 157 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(6559, 274, true);
            WriteLiteral(@"        </div>
    </div>
</div>
<!-- Event Area End -->
<!-- Testimonial Area Start -->
<div class=""testimonial-area pt-110 pb-105 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""testimonial-owl owl-theme owl-carousel"">
");
            EndContext();
#line 167 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                 foreach (Testimonial item in Model.Testimonials)
                {

#line default
#line hidden
            BeginContext(6919, 291, true);
            WriteLiteral(@"                    <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                        <div class=""single-testimonial"">
                            <div class=""testimonial-info"">
                                <div class=""testimonial-img"">
                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 7210, "\"", 7243, 2);
            WriteAttributeValue("", 7216, "img/testimonial/", 7216, 16, true);
#line 173 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 7232, item.Image, 7232, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7244, 167, true);
            WriteLiteral(" alt=\"testimonial\">\r\n                                </div>\r\n                                <div class=\"testimonial-content\">\r\n                                    <p>");
            EndContext();
            BeginContext(7412, 11, false);
#line 176 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                  Write(item.Review);

#line default
#line hidden
            EndContext();
            BeginContext(7423, 46, true);
            WriteLiteral("</p>\r\n                                    <h4>");
            EndContext();
            BeginContext(7470, 13, false);
#line 177 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                   Write(item.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(7483, 47, true);
            WriteLiteral("</h4>\r\n                                    <h5>");
            EndContext();
            BeginContext(7531, 9, false);
#line 178 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                   Write(item.Duty);

#line default
#line hidden
            EndContext();
            BeginContext(7540, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(7543, 18, false);
#line 178 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                               Write(item.Qualification);

#line default
#line hidden
            EndContext();
            BeginContext(7561, 143, true);
            WriteLiteral("</h5>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 183 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(7723, 522, true);
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>
<!-- Testimonial Area End -->
<!-- Blog Area Start -->
<div class=""blog-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title text-center"">
                    <img src=""img/icon/section.png"" alt=""section-title"">
                    <h2>LATEST FROM BLOG</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            ");
            EndContext();
            BeginContext(8246, 39, false);
#line 201 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
       Write(await  Component.InvokeAsync("Blogs",3));

#line default
#line hidden
            EndContext();
            BeginContext(8285, 64, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Blog Area End -->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
