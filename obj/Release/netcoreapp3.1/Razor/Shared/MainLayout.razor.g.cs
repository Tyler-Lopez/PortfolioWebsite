#pragma checksum "C:\Users\Tyler\Documents\GitHub\PortfolioWebsite\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15ce9c088acf035b03a63c3a84aec87556014e37"
// <auto-generated/>
#pragma warning disable 1591
namespace Portfolio.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Tyler\Documents\GitHub\PortfolioWebsite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tyler\Documents\GitHub\PortfolioWebsite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tyler\Documents\GitHub\PortfolioWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tyler\Documents\GitHub\PortfolioWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tyler\Documents\GitHub\PortfolioWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tyler\Documents\GitHub\PortfolioWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tyler\Documents\GitHub\PortfolioWebsite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tyler\Documents\GitHub\PortfolioWebsite\_Imports.razor"
using Portfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tyler\Documents\GitHub\PortfolioWebsite\_Imports.razor"
using Portfolio.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<link rel=""preconnect"" href=""https://fonts.googleapis.com"">
<link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
<link href=""https://fonts.googleapis.com/css2?family=Roboto+Slab:wght@100;200;300;400;500;600;700;800;900&family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap"" rel=""stylesheet"">
");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "main");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, @"<nav class=""navbar navbar-expand-lg navbar-light background-black"">
        <a class=""navbar-brand text-white-50"" style=""font-family: 'Roboto Slab', serif;"" href=""#"">Tyler Lopez, Android Engineer</a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNavAltMarkup"" aria-controls=""navbarNavAltMarkup"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse"" id=""navbarNavAltMarkup"">
            <div class=""navbar-nav"">
                <a class=""nav-item nav-link text-white"" href=""https://github.com/Tyler-Lopez"">
                    <i class=""fab fa-github-square text-white"" style=""font-size:1.8rem""></i>
                    </a>
                    <a class=""nav-item nav-link text-white"" href=""https://www.linkedin.com/in/tylerlopez/"">

                        <i class=""fab fa-linkedin text-white"" style=""font-size:1.8rem""></i>


                    </a>
</div>
        </div>
    </nav>

    ");
            __builder.AddContent(5, 
#nullable restore
#line 30 "C:\Users\Tyler\Documents\GitHub\PortfolioWebsite\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
