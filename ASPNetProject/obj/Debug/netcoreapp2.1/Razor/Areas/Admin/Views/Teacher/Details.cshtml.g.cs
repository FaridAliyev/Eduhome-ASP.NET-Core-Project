#pragma checksum "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cf4a48496c1ee5a6ea2a1e37da6dfb15eb26d11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Teacher_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Teacher/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Teacher/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Teacher_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cf4a48496c1ee5a6ea2a1e37da6dfb15eb26d11", @"/Areas/Admin/Views/Teacher/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fe69668118451dfbd039da4227812d30ccafe4e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Teacher_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeachersVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:470px;height:480px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark btn-icon-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
  
    ViewData["Title"] = "Teacher Details";

#line default
#line hidden
            BeginContext(70, 257, true);
            WriteLiteral(@"
    <div class=""teacher-details-area pt-150 pb-60"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-5 col-sm-5 col-xs-12"">
                    <div class=""teacher-details-img"">
                        ");
            EndContext();
            BeginContext(327, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5521062cb9204939a51a4a8b6b92a5ba", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 337, "~/img/teacher/", 337, 14, true);
#line 11 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
AddHtmlAttributeValue("", 351, Model.Teacher.Image, 351, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(420, 206, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-7 col-sm-7 col-xs-12\">\r\n                    <div class=\"teacher-details-content ml-50\">\r\n                        <h2>");
            EndContext();
            BeginContext(627, 22, false);
#line 16 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                       Write(Model.Teacher.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(649, 35, true);
            WriteLiteral("</h2>\r\n                        <h5>");
            EndContext();
            BeginContext(685, 39, false);
#line 17 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                       Write(Model.Teacher.TeacherInfo.Qualification);

#line default
#line hidden
            EndContext();
            BeginContext(724, 77, true);
            WriteLiteral("</h5>\r\n                        <h4>about me</h4>\r\n                        <p>");
            EndContext();
            BeginContext(802, 41, false);
#line 19 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                      Write(Html.Raw(Model.Teacher.TeacherInfo.About));

#line default
#line hidden
            EndContext();
            BeginContext(843, 123, true);
            WriteLiteral("</p>\r\n                        <ul>\r\n                            <li>\r\n                                <span>degree: </span>");
            EndContext();
#line 22 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                                                      foreach (TeacherDegree item in Model.TeacherDegrees)
                                {
                                    if (item.TeacherId == Model.Teacher.Id)
                                    {
                                        

#line default
#line hidden
            BeginContext(1213, 16, false);
#line 26 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                                   Write(item.Degree.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1229, 17, true);
            WriteLiteral("<span>, </span>\r\n");
            EndContext();
#line 27 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(1320, 92, true);
            WriteLiteral("                            </li>\r\n                            <li><span>experience: </span>");
            EndContext();
            BeginContext(1413, 40, false);
#line 30 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                                                    Write(Model.Teacher.TeacherInfo.ExperienceYear);

#line default
#line hidden
            EndContext();
            BeginContext(1453, 112, true);
            WriteLiteral(" years experience</li>\r\n                            <li>\r\n                                <span>hobbies: </span>");
            EndContext();
#line 32 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                                                       foreach (TeacherHobbie item in Model.TeacherHobbies)
                                {
                                    if (item.TeacherId == Model.Teacher.Id)
                                    {
                                        

#line default
#line hidden
            BeginContext(1812, 16, false);
#line 36 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                                   Write(item.Hobbie.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1828, 17, true);
            WriteLiteral("<span>, </span>\r\n");
            EndContext();
#line 37 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(1919, 89, true);
            WriteLiteral("                            </li>\r\n                            <li><span>faculty: </span>");
            EndContext();
            BeginContext(2009, 26, false);
#line 40 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                                                 Write(Model.Teacher.Faculty.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2035, 345, true);
            WriteLiteral(@"</li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-3 col-sm-4"">
                    <div class=""teacher-contact"">
                        <h4>contact information</h4>
                        <p><span>mail me : </span>");
            EndContext();
            BeginContext(2381, 31, false);
#line 49 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                                             Write(Model.Teacher.TeacherInfo.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2412, 60, true);
            WriteLiteral("</p>\r\n                        <p><span>make a call : </span>");
            EndContext();
            BeginContext(2473, 31, false);
#line 50 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                                                 Write(Model.Teacher.TeacherInfo.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(2504, 55, true);
            WriteLiteral("</p>\r\n                        <p><span>skype : </span> ");
            EndContext();
            BeginContext(2560, 31, false);
#line 51 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                                            Write(Model.Teacher.TeacherInfo.Skype);

#line default
#line hidden
            EndContext();
            BeginContext(2591, 108, true);
            WriteLiteral("</p>\r\n                        <ul style=\"display:flex; list-style:none\">\r\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2699, "\"", 2741, 1);
#line 53 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue("", 2706, Model.Teacher.TeacherInfo.Facebook, 2706, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2742, 105, true);
            WriteLiteral("><i class=\"mdi mdi-facebook-box\" style=\"font-size:30px\"></i></a></li>\r\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2847, "\"", 2890, 1);
#line 54 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue("", 2854, Model.Teacher.TeacherInfo.Pinterest, 2854, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2891, 106, true);
            WriteLiteral("><i class=\"mdi mdi-pinterest-box\" style=\"font-size:30px\"></i></a></li>\r\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2997, "\"", 3036, 1);
#line 55 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue("", 3004, Model.Teacher.TeacherInfo.Vimeo, 3004, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3037, 98, true);
            WriteLiteral("><i class=\"mdi mdi-vimeo\" style=\"font-size:30px\"></i></a></li>\r\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3135, "\"", 3176, 1);
#line 56 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue("", 3142, Model.Teacher.TeacherInfo.Twitter, 3142, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3177, 729, true);
            WriteLiteral(@"><i class=""mdi mdi-twitter"" style=""font-size:30px""></i></a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-md-9 col-sm-8"">
                    <div class=""skill-area"">
                        <h4>skills</h4>
                    </div>
                    <div class=""skill-wrapper"">
                        <div class=""row"">
                            <div class=""col-sm-4"">
                                <div class=""skill-bar-item"">
                                    <span>language</span>
                                    <div class=""progress"">
                                        <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3906, "\"", 4050, 11);
            WriteAttributeValue("", 3914, "width:", 3914, 6, true);
#line 70 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue(" ", 3920, Model.Teacher.Skill.Language, 3921, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 3950, "%;", 3950, 2, true);
            WriteAttributeValue(" ", 3952, "visibility:", 3953, 12, true);
            WriteAttributeValue(" ", 3964, "visible;", 3965, 9, true);
            WriteAttributeValue(" ", 3973, "animation-duration:", 3974, 20, true);
            WriteAttributeValue(" ", 3993, "1.5s;", 3994, 6, true);
            WriteAttributeValue(" ", 3999, "animation-delay:", 4000, 17, true);
            WriteAttributeValue(" ", 4016, "1.2s;", 4017, 6, true);
            WriteAttributeValue(" ", 4022, "animation-name:", 4023, 16, true);
            WriteAttributeValue(" ", 4038, "fadeInLeft;", 4039, 12, true);
            EndWriteAttribute();
            BeginContext(4051, 126, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                            <span class=\"text-top\">");
            EndContext();
            BeginContext(4178, 28, false);
#line 71 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                                                              Write(Model.Teacher.Skill.Language);

#line default
#line hidden
            EndContext();
            BeginContext(4206, 505, true);
            WriteLiteral(@"%</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-sm-4"">
                                <div class=""skill-bar-item"">
                                    <span>team leader</span>
                                    <div class=""progress"">
                                        <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 4711, "\"", 4857, 11);
            WriteAttributeValue("", 4719, "width:", 4719, 6, true);
#line 80 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue(" ", 4725, Model.Teacher.Skill.TeamLeader, 4726, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 4757, "%;", 4757, 2, true);
            WriteAttributeValue(" ", 4759, "visibility:", 4760, 12, true);
            WriteAttributeValue(" ", 4771, "visible;", 4772, 9, true);
            WriteAttributeValue(" ", 4780, "animation-duration:", 4781, 20, true);
            WriteAttributeValue(" ", 4800, "1.5s;", 4801, 6, true);
            WriteAttributeValue(" ", 4806, "animation-delay:", 4807, 17, true);
            WriteAttributeValue(" ", 4823, "1.2s;", 4824, 6, true);
            WriteAttributeValue(" ", 4829, "animation-name:", 4830, 16, true);
            WriteAttributeValue(" ", 4845, "fadeInLeft;", 4846, 12, true);
            EndWriteAttribute();
            BeginContext(4858, 126, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                            <span class=\"text-top\">");
            EndContext();
            BeginContext(4985, 30, false);
#line 81 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                                                              Write(Model.Teacher.Skill.TeamLeader);

#line default
#line hidden
            EndContext();
            BeginContext(5015, 505, true);
            WriteLiteral(@"%</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-sm-4"">
                                <div class=""skill-bar-item"">
                                    <span>development</span>
                                    <div class=""progress"">
                                        <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 5520, "\"", 5667, 11);
            WriteAttributeValue("", 5528, "width:", 5528, 6, true);
#line 90 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue(" ", 5534, Model.Teacher.Skill.Development, 5535, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 5567, "%;", 5567, 2, true);
            WriteAttributeValue(" ", 5569, "visibility:", 5570, 12, true);
            WriteAttributeValue(" ", 5581, "visible;", 5582, 9, true);
            WriteAttributeValue(" ", 5590, "animation-duration:", 5591, 20, true);
            WriteAttributeValue(" ", 5610, "1.5s;", 5611, 6, true);
            WriteAttributeValue(" ", 5616, "animation-delay:", 5617, 17, true);
            WriteAttributeValue(" ", 5633, "1.2s;", 5634, 6, true);
            WriteAttributeValue(" ", 5639, "animation-name:", 5640, 16, true);
            WriteAttributeValue(" ", 5655, "fadeInLeft;", 5656, 12, true);
            EndWriteAttribute();
            BeginContext(5668, 126, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                            <span class=\"text-top\">");
            EndContext();
            BeginContext(5795, 31, false);
#line 91 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                                                              Write(Model.Teacher.Skill.Development);

#line default
#line hidden
            EndContext();
            BeginContext(5826, 500, true);
            WriteLiteral(@"%</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-sm-4"">
                                <div class=""skill-bar-item"">
                                    <span>design</span>
                                    <div class=""progress"">
                                        <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 6326, "\"", 6468, 11);
            WriteAttributeValue("", 6334, "width:", 6334, 6, true);
#line 100 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue(" ", 6340, Model.Teacher.Skill.Design, 6341, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 6368, "%;", 6368, 2, true);
            WriteAttributeValue(" ", 6370, "visibility:", 6371, 12, true);
            WriteAttributeValue(" ", 6382, "visible;", 6383, 9, true);
            WriteAttributeValue(" ", 6391, "animation-duration:", 6392, 20, true);
            WriteAttributeValue(" ", 6411, "1.5s;", 6412, 6, true);
            WriteAttributeValue(" ", 6417, "animation-delay:", 6418, 17, true);
            WriteAttributeValue(" ", 6434, "1.2s;", 6435, 6, true);
            WriteAttributeValue(" ", 6440, "animation-name:", 6441, 16, true);
            WriteAttributeValue(" ", 6456, "fadeInLeft;", 6457, 12, true);
            EndWriteAttribute();
            BeginContext(6469, 126, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                            <span class=\"text-top\">");
            EndContext();
            BeginContext(6596, 26, false);
#line 101 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                                                              Write(Model.Teacher.Skill.Design);

#line default
#line hidden
            EndContext();
            BeginContext(6622, 504, true);
            WriteLiteral(@"%</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-sm-4"">
                                <div class=""skill-bar-item"">
                                    <span>innovation</span>
                                    <div class=""progress"">
                                        <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 7126, "\"", 7272, 11);
            WriteAttributeValue("", 7134, "width:", 7134, 6, true);
#line 110 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue(" ", 7140, Model.Teacher.Skill.Innovation, 7141, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 7172, "%;", 7172, 2, true);
            WriteAttributeValue(" ", 7174, "visibility:", 7175, 12, true);
            WriteAttributeValue(" ", 7186, "visible;", 7187, 9, true);
            WriteAttributeValue(" ", 7195, "animation-duration:", 7196, 20, true);
            WriteAttributeValue(" ", 7215, "1.5s;", 7216, 6, true);
            WriteAttributeValue(" ", 7221, "animation-delay:", 7222, 17, true);
            WriteAttributeValue(" ", 7238, "1.2s;", 7239, 6, true);
            WriteAttributeValue(" ", 7244, "animation-name:", 7245, 16, true);
            WriteAttributeValue(" ", 7260, "fadeInLeft;", 7261, 12, true);
            EndWriteAttribute();
            BeginContext(7273, 126, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                            <span class=\"text-top\">");
            EndContext();
            BeginContext(7400, 30, false);
#line 111 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                                                              Write(Model.Teacher.Skill.Innovation);

#line default
#line hidden
            EndContext();
            BeginContext(7430, 507, true);
            WriteLiteral(@"%</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-sm-4"">
                                <div class=""skill-bar-item"">
                                    <span>communication</span>
                                    <div class=""progress"">
                                        <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 7937, "\"", 8086, 11);
            WriteAttributeValue("", 7945, "width:", 7945, 6, true);
#line 120 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue(" ", 7951, Model.Teacher.Skill.Communication, 7952, 34, false);

#line default
#line hidden
            WriteAttributeValue("", 7986, "%;", 7986, 2, true);
            WriteAttributeValue(" ", 7988, "visibility:", 7989, 12, true);
            WriteAttributeValue(" ", 8000, "visible;", 8001, 9, true);
            WriteAttributeValue(" ", 8009, "animation-duration:", 8010, 20, true);
            WriteAttributeValue(" ", 8029, "1.5s;", 8030, 6, true);
            WriteAttributeValue(" ", 8035, "animation-delay:", 8036, 17, true);
            WriteAttributeValue(" ", 8052, "1.2s;", 8053, 6, true);
            WriteAttributeValue(" ", 8058, "animation-name:", 8059, 16, true);
            WriteAttributeValue(" ", 8074, "fadeInLeft;", 8075, 12, true);
            EndWriteAttribute();
            BeginContext(8087, 126, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                            <span class=\"text-top\">");
            EndContext();
            BeginContext(8214, 33, false);
#line 121 "E:\Projects\ASPNetProject\Areas\Admin\Views\Teacher\Details.cshtml"
                                                              Write(Model.Teacher.Skill.Communication);

#line default
#line hidden
            EndContext();
            BeginContext(8247, 278, true);
            WriteLiteral(@"%</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                ");
            EndContext();
            BeginContext(8525, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8daa2ee9464b40a193c869aa21f542f3", async() => {
                BeginContext(8582, 127, true);
                WriteLiteral("\r\n                    Go Back\r\n                    <i class=\"mdi mdi-keyboard-backspace btn-icon-append\"></i>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8713, 52, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeachersVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
