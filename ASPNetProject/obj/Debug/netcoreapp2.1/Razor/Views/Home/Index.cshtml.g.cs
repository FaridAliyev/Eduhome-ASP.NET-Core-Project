#pragma checksum "E:\Projects\ASPNetProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a2f66589ff7ed626eae1f3c6f39ac023e00b667"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a2f66589ff7ed626eae1f3c6f39ac023e00b667", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75ad261125fd47f9d3a83db31753885bdcad958", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
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
            BeginContext(962, 414, true);
            WriteLiteral(@"</p>
                                        <a class=""default-btn"" href=""about.html"">Learn more</a>
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
            BeginContext(1387, 180, true);
            WriteLiteral("    </div>\r\n</section>\r\n<!-- Background Area End -->\r\n<!-- Service Start -->\r\n<div class=\"service-area two pt-150 pb-150\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 40 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
             foreach (Service item in Model.Services)
            {

#line default
#line hidden
            BeginContext(1637, 160, true);
            WriteLiteral("                <div class=\"col-md-4 col-sm-4 col-xs-12\">\r\n                    <div class=\"single-service\">\r\n                        <h3><a href=\"teacher.html\">");
            EndContext();
            BeginContext(1798, 9, false);
#line 44 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                              Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1807, 38, true);
            WriteLiteral("</a></h3>\r\n                        <p>");
            EndContext();
            BeginContext(1846, 16, false);
#line 45 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                      Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1862, 59, true);
            WriteLiteral(" </p>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 48 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1936, 300, true);
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
            BeginContext(2237, 16, false);
#line 59 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                    Write(Model.About.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2253, 37, true);
            WriteLiteral("</span></h2>\r\n                    <p>");
            EndContext();
            BeginContext(2291, 23, false);
#line 60 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                  Write(Model.About.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2314, 47, true);
            WriteLiteral("</p>\r\n                    <p class=\"hidden-sm\">");
            EndContext();
            BeginContext(2362, 23, false);
#line 61 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
                                    Write(Model.About.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2385, 239, true);
            WriteLiteral("</p>\r\n                    <a class=\"default-btn\" href=\"about.html\">view courses</a>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6 col-sm-6\">\r\n                <div class=\"about-img\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2624, "\"", 2658, 2);
            WriteAttributeValue("", 2630, "img/about/", 2630, 10, true);
#line 67 "E:\Projects\ASPNetProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 2640, Model.About.Image, 2640, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2659, 15306, true);
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
            <div class=""col-md-4 col-sm-6 col-xs-12"">
                <div class=""single-course"">
                    <div class=""course-img"">
                        <a href=""course-details.html"">
                            <img src=""img/course/course1.jpg"" alt=""course"">
                            <div class=""course-hover"">
                                <i class=""fa fa-link""></i>
                            </div>
                        </a>
              ");
            WriteLiteral(@"      </div>
                    <div class=""course-content"">
                        <h3><a href=""course-details.html"">CSE ENGINEERING</a></h3>
                        <p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness</p>
                        <a class=""default-btn"" href=""course-details.html"">read more</a>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 col-sm-6 col-xs-12"">
                <div class=""single-course"">
                    <div class=""course-img"">
                        <a href=""course-details.html"">
                            <img src=""img/course/course2.jpg"" alt=""course"">
                            <div class=""course-hover"">
                                <i class=""fa fa-link""></i>
                            </div>
                        </a>
                    </div>
                    <div class=""course-content"">
                      ");
            WriteLiteral(@"  <h3><a href=""course-details.html"">political science</a></h3>
                        <p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness</p>
                        <a class=""default-btn"" href=""course-details.html"">read more</a>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 hidden-sm col-xs-12"">
                <div class=""single-course"">
                    <div class=""course-img"">
                        <a href=""course-details.html"">
                            <img src=""img/course/course3.jpg"" alt=""course"">
                            <div class=""course-hover"">
                                <i class=""fa fa-link""></i>
                            </div>
                        </a>
                    </div>
                    <div class=""course-content"">
                        <h3><a href=""course-details.html"">micro biology</a></h3>
                       ");
            WriteLiteral(@" <p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness</p>
                        <a class=""default-btn"" href=""course-details.html"">read more</a>
                    </div>
                </div>
            </div>
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
                    <div class=""notice-video"">
                        <div class=""video-icon video-hover"">
                            <a class=""video-popup"" href=""https://www.youtube.com/watch?v=to6Ghf8UL7o"">
                                <i class=""zmdi zmdi-play""></i>
                            </a>
                        </div>
                    </div>
         ");
            WriteLiteral(@"       </div>
            </div>
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-left-wrapper"">
                    <h3>notice board</h3>
                    <div class=""notice-left"">
                        <div class=""single-notice-left mb-23 pb-20"">
                            <h4>5, June 2017</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left hidden-sm mb-23 pb-20"">
                            <h4>4, June 2017</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left pb-70"">
                            <h4>3, June 2017</h4>
                            <p");
            WriteLiteral(@">I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left mb-23 pb-20"">
                            <h4>5, June 2017</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left hidden-sm mb-23 pb-20"">
                            <h4>4, June 2017</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left pb-70"">
                            <h4>3, June 2017</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing");
            WriteLiteral(@" plasure and praising pain was born and I will give you a complete </p>
                        </div>
                    </div>
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
                    <h2>UPCOMMING EVENTS</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 col-sm-12 col-xs-12"">
                <div class=""single-event mb-35"">
                    <div class=""event-img"">
                        <a href=""event-details.html""><img src=""img/event/event1.jpg"" alt=""event""></a>
                    </div>
                    <div class=""event-content text-left"">
                ");
            WriteLiteral(@"        <h3>20 June 2017</h3>
                        <h4><a href=""event-details.html"">ADVANCE PHP WORKSHOP</a></h4>
                        <ul>
                            <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                            <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                        </ul>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
                <div class=""single-event hidden-sm hidden-xs"">
                    <div class=""event-img"">
                        <a href=""event-details.html""><img src=""img/event/event3.jpg"" alt=""event""></a>
                    </div>
                    <div class=""event-content text-left"">
                        <h3>16 June 2017</h3>
                        <h4><a href=""event-details.html"">learning english history</a></h4>
  ");
            WriteLiteral(@"                      <ul>
                            <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                            <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                        </ul>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-sm-12 col-xs-12"">
                <div class=""single-event mb-35"">
                    <div class=""event-img"">
                        <a href=""event-details.html""><img src=""img/event/event2.jpg"" alt=""event""></a>
                    </div>
                    <div class=""event-content text-left"">
                        <h3>18 June 2017</h3>
                        <h4><a href=""event-details.html"">DIGITAL MARKETING ANALYSIS</a></h4>
                        <ul>
                            <");
            WriteLiteral(@"li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                            <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                        </ul>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
                <div class=""single-event hidden-sm hidden-xs"">
                    <div class=""event-img"">
                        <a href=""event-details.html""><img src=""img/event/event3.jpg"" alt=""event""></a>
                    </div>
                    <div class=""event-content text-left"">
                        <h3>14 June 2017</h3>
                        <h4><a href=""event-details.html"">UI & UX DESIGNER MEETUP</a></h4>
                        <ul>
                            <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                            <li><i class=""fa fa-map-marker""></i>Ne");
            WriteLiteral(@"w Yourk City</li>
                        </ul>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Event Area End -->
<!-- Testimonial Area Start -->
<div class=""testimonial-area pt-110 pb-105 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""testimonial-owl owl-theme owl-carousel"">
                <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                    <div class=""single-testimonial"">
                        <div class=""testimonial-info"">
                            <div class=""testimonial-img"">
                                <img src=""img/testimonial/testimonial.jpg"" alt=""testimonial"">
                            </div>
                            <div class=""testimonial-content"">
                 ");
            WriteLiteral(@"               <p>I must explain to you how all this mistaken idea of denoung pleure and praising pain was born and I will give you a coete account of the system, and expound the actual</p>
                                <h4>David Morgan</h4>
                                <h5>Student, CSE</h5>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
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
            <div class=""col-md-4 col-sm-6 col-xs-12"">
                <div class=""single-blo");
            WriteLiteral(@"g"">
                    <div class=""blog-img"">
                        <a href=""blog-details.html""><img src=""img/blog/blog1.jpg"" alt=""blog""></a>
                        <div class=""blog-hover"">
                            <a href=""blog-details.html""><i class=""fa fa-link""></i></a>
                        </div>
                    </div>
                    <div class=""blog-content"">
                        <div class=""blog-top"">
                            <p>By Alex  /  June 20, 2017  /  <i class=""fa fa-comments-o""></i> 4</p>
                        </div>
                        <div class=""blog-bottom"">
                            <h2><a href=""blog-details.html"">I must explain to you how all this a mistaken idea </a></h2>
                            <a href=""blog-details.html"">read more</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 col-sm-6 col-xs-12"">
                <div class=""single-blog"">
   ");
            WriteLiteral(@"                 <div class=""blog-img"">
                        <a href=""blog-details.html""><img src=""img/blog/blog2.jpg"" alt=""blog""></a>
                        <div class=""blog-hover"">
                            <a href=""blog-details.html""><i class=""fa fa-link""></i></a>
                        </div>
                    </div>
                    <div class=""blog-content"">
                        <div class=""blog-top"">
                            <p>By Alex  /  June 20, 2017  /  <i class=""fa fa-comments-o""></i> 4</p>
                        </div>
                        <div class=""blog-bottom"">
                            <h2><a href=""blog-details.html"">I must explain to you how all this a mistaken idea </a></h2>
                            <a href=""blog-details.html"">read more</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 hidden-sm col-xs-12"">
                <div class=""single-blog"">
          ");
            WriteLiteral(@"          <div class=""blog-img"">
                        <a href=""blog-details.html""><img src=""img/blog/blog3.jpg"" alt=""blog""></a>
                        <div class=""blog-hover"">
                            <a href=""blog-details.html""><i class=""fa fa-link""></i></a>
                        </div>
                    </div>
                    <div class=""blog-content"">
                        <div class=""blog-top"">
                            <p>By Alex  /  June 20, 2017  /  <i class=""fa fa-comments-o""></i> 4</p>
                        </div>
                        <div class=""blog-bottom"">
                            <h2><a href=""blog-details.html"">I must explain to you how all this a mistaken idea </a></h2>
                            <a href=""blog-details.html"">read more</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Blog Area End -->

");
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