#pragma checksum "C:\Users\Manu\AssignmentDNP2\AssignmentDNP2\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a350032d3fcc147c7d56537c6fd1f01f3c7780a"
// <auto-generated/>
#pragma warning disable 1591
namespace AssignmentDNP2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Manu\AssignmentDNP2\AssignmentDNP2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Manu\AssignmentDNP2\AssignmentDNP2\_Imports.razor"
using Microsoft.AspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Manu\AssignmentDNP2\AssignmentDNP2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Manu\AssignmentDNP2\AssignmentDNP2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Manu\AssignmentDNP2\AssignmentDNP2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Manu\AssignmentDNP2\AssignmentDNP2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Manu\AssignmentDNP2\AssignmentDNP2\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Manu\AssignmentDNP2\AssignmentDNP2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Manu\AssignmentDNP2\AssignmentDNP2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Manu\AssignmentDNP2\AssignmentDNP2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Manu\AssignmentDNP2\AssignmentDNP2\_Imports.razor"
using AssignmentDNP2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Manu\AssignmentDNP2\AssignmentDNP2\_Imports.razor"
using AssignmentDNP2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Manu\AssignmentDNP2\AssignmentDNP2\_Imports.razor"
using FileData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Family Manager</h1>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page");
            __builder.AddMarkupContent(3, "<div class=\"sidebar\"></div>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "top-row px-4");
            __builder.OpenElement(8, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-md-4");
                __builder2.OpenElement(14, "h3");
                __builder2.AddContent(15, 
#nullable restore
#line 18 "C:\Users\Manu\AssignmentDNP2\AssignmentDNP2\Pages\Index.razor"
                                   context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n                        <img style=\"display: inline;\" src=\"css/icon/user-icon-jpg-4.jpg\" alt=\"logo\">");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
