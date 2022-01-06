#pragma checksum "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0db56083e47bc8424931509374d98ff750051e3"
// <auto-generated/>
#pragma warning disable 1591
namespace Portfolio.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\_Imports.razor"
using Portfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\_Imports.razor"
using Portfolio.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\Pages\Index.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\Pages\Index.razor"
using Portfolio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\Pages\Index.razor"
using Portfolio.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"jumbotron texture-background mb-0 rounded-0\">\r\n    <div class=\"background-grey p-4 mb-0 rounded-lg shadow-lg border border-dark\">\r\n        \r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12 col-xl-7 p-4 text-md-center\">\r\n                <h2 style=\"color: #00274C; font-weight: 700; font-size: 2.5rem; font-family: \'Roboto\', serif;\">Hi there,</h2>\r\n                <div class=\"px-4\">\r\n                    <p style=\"font-family: \'Roboto\', sans-serif; font-size: 1.5rem;\">I am an early-career Android developer with a unique background and a proven record for creativity and learning new technologies efficiently.</p>\r\n                    <p style=\"font-family: \'Roboto\', sans-serif; font-size: 1.5rem;\">\r\n                        After earning a chemistry degree from U of M, in my laboratory work I found that I was competent at and immensely enjoyed providing internal IT support and developing intranet sites.\r\n                        Over time, I opted to pivot my career and enrolled in the computer science program at EMU, where I currently maintain a 4.0 GPA.\r\n                    </p>\r\n                    <p style=\"font-family: \'Roboto\', sans-serif; font-size: 1.5rem;\">\r\n                        I have multiple hobbyist passion projects, many of which are Google Play Store-published Android Applications.\r\n                        This Summer, I will joining Strava as an Android Engineer Intern - an opportunity I eagerly await.\r\n                    </p>\r\n                    <img width=\"400rem\" class=\"mt-4\" fill=\"#00274C;\" src=\"Siggy3.svg\">\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-12 col-xl-5 justify-content-center text-center\">\r\n\r\n                <img class=\"rounded-circle shadow-md p-0 m-5\" style=\"border: 0.7rem solid #FFCB05;\" width=\"400rem\" height=\"auto\" src=\"headshotthumb.png\">\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row  justify-content-center mt-0 p-4");
            __builder.AddAttribute(3, "style", "background-color: #FFCB05;");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-xl-8 p-4 m-2   rounded-lg shadow-lg bg-white sketchyWhite");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-5 pl-2 pr-4 text-center justify-content-center");
            __builder.AddAttribute(13, "style", "display: flex; align-items: center");
            __builder.AddMarkupContent(14, "\r\n                \r\n                ");
            __builder.OpenElement(15, "svg");
            __builder.AddAttribute(16, "class", "button-next swing my-2");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\Pages\Index.razor"
                                                              SafeDecrement

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "xmlns", "http://www.w3.org/2000/svg");
            __builder.AddAttribute(19, "width", "50");
            __builder.AddAttribute(20, "height", "50");
            __builder.AddAttribute(21, "viewBox", "0 0 24 24");
            __builder.AddMarkupContent(22, "<path d=\"M16.67 0l2.83 2.829-9.339 9.175 9.339 9.167-2.83 2.829-12.17-11.996z\"></path>");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "img");
            __builder.AddAttribute(25, "style", "border: 3px solid #00274c;");
            __builder.AddAttribute(26, "width", "250rem");
            __builder.AddAttribute(27, "src", 
#nullable restore
#line 65 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\Pages\Index.razor"
                                                                             Projects[ActiveIndex].PictureUrl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "svg");
            __builder.AddAttribute(30, "class", "button-next swing my-2");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\Pages\Index.razor"
                                                              SafeIncrement

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "width", "50");
            __builder.AddAttribute(33, "height", "50");
            __builder.AddAttribute(34, "viewBox", "0 0 24 24");
            __builder.AddMarkupContent(35, "<path d=\"M5 3l3.057-3 11.943 12-11.943 12-3.057-3 9-9z\"></path>");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col-md-7 p-4 my-4 align-content-center justify-content-center");
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "h2");
            __builder.AddAttribute(42, "style", "color: #00274C; font-weight: 700; font-size: 2.5rem; font-family: \'Roboto\', serif;");
            __builder.AddContent(43, 
#nullable restore
#line 69 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\Pages\Index.razor"
                                                                                                                Projects[ActiveIndex].Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "p");
            __builder.AddAttribute(46, "style", "font-family: \'Roboto\', sans-serif; font-size: 1.5rem;");
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.AddContent(48, 
#nullable restore
#line 71 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\Pages\Index.razor"
                     Projects[ActiveIndex].Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "style", "font-family: \'Roboto\', sans-serif; font-size: 4.0rem; display: flex; align-items: center");
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 74 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\Pages\Index.razor"
                      
                        if (@Projects[ActiveIndex].PlayStoreUrl != null)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "                            ");
            __builder.OpenElement(55, "a");
            __builder.AddAttribute(56, "href", 
#nullable restore
#line 77 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\Pages\Index.razor"
                                      Projects[ActiveIndex].PlayStoreUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(57, "<img alt=\"Get it on Google Play\" height=\"75\" src=\"https://play.google.com/intl/en_us/badges/static/images/badges/en_badge_web_generic.png\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 78 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\Pages\Index.razor"
                        }
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "                    ");
            __builder.OpenElement(60, "a");
            __builder.AddAttribute(61, "href", 
#nullable restore
#line 80 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\Pages\Index.razor"
                              Projects[ActiveIndex].GithubUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(62, "\r\n                        <img height=\"50\" src=\"GitHub_Logo.png\">\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\r\n    ");
            __builder.AddMarkupContent(68, @"<div class=""col-xl p-4 m-2 rounded-lg shadow-lg sketchy foo "">
        <div class=""row"">
            <div class=""col p-4 my-4"">
                    <h2 style=""color: #00274C; font-weight: 700; font-size: 2.5rem; font-family: 'Roboto', serif;"">Contact Me</h2>
                <p style=""font-family: 'Roboto', sans-serif; font-size: 1.5rem;""><i class=""fas fa-envelope""></i> <a href=""mailto: tylerlopez@gmail.com"">tylerlopezmi@gmail.com</a></p>
                        <p style=""font-family: 'Roboto', sans-serif; font-size: 1.5rem;""><i class=""fas fa-phone-square-alt""></i> (989) 964-8982</p>
                    </div>
                </div>
            </div>
        ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\tylop\source\repos\BeckyBlog\PortfolioWebsite\Pages\Index.razor"
 
    public static ProjectService ProductService = new ProjectService();

    public List<Project> Projects { get; private set; }

    public int ActiveIndex = 0;
    protected override async Task OnInitializedAsync()
    {
        Projects = ProductService.GetAll();
    }

    public void SafeIncrement()
    {
        if (ActiveIndex + 1 < Projects.Count) ActiveIndex++;
        else ActiveIndex = 0;
    }
    public void SafeDecrement()
    {
        if (ActiveIndex - 1 < 0) ActiveIndex = Projects.Count - 1;
        else ActiveIndex--;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
