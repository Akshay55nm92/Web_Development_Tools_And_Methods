#pragma checksum "C:\Users\hp\Documents\NEU Subjects\Fall 2018\WebDev\FinalProject\Part3\ShoppingCart\ShoppingCart.Client\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d6389f441e03f806b24e91840eefb3a0d63a697"
// <auto-generated/>
#pragma warning disable 1591
namespace ShoppingCart.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using ShoppingCart.Client;
    using ShoppingCart.Client.Shared;
    using ShoppingCart.Shared.Models;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/home")]
    public class Index : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\n\nWelcome to your new app.\n\n\n");
#line 12 "C:\Users\hp\Documents\NEU Subjects\Fall 2018\WebDev\FinalProject\Part3\ShoppingCart\ShoppingCart.Client\Pages\Index.cshtml"
 if (usr == null)
{

#line default
#line hidden
            builder.AddContent(1, "    ");
            builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\n");
#line 15 "C:\Users\hp\Documents\NEU Subjects\Fall 2018\WebDev\FinalProject\Part3\ShoppingCart\ShoppingCart.Client\Pages\Index.cshtml"
}

else
{

#line default
#line hidden
            builder.AddContent(3, "    ");
            builder.OpenElement(4, "table");
            builder.AddContent(5, "\n        ");
            builder.AddMarkupContent(6, "<thead>\n            <tr>\n                <th>ID</th>\n                <th>PWD</th>\n                <th>Role</th>\n            </tr>\n        </thead>\n        ");
            builder.OpenElement(7, "tbody");
            builder.AddContent(8, "\n           \n                ");
            builder.OpenElement(9, "tr");
            builder.AddContent(10, "\n                    ");
            builder.OpenElement(11, "td");
            builder.AddContent(12, usr.UserId);
            builder.CloseElement();
            builder.AddContent(13, "\n                    ");
            builder.OpenElement(14, "td");
            builder.AddContent(15, usr.Password);
            builder.CloseElement();
            builder.AddContent(16, "\n                    ");
            builder.OpenElement(17, "td");
            builder.AddContent(18, usr.Role);
            builder.CloseElement();
            builder.AddContent(19, "\n                ");
            builder.CloseElement();
            builder.AddContent(20, "\n            \n        ");
            builder.CloseElement();
            builder.AddContent(21, "\n    ");
            builder.CloseElement();
            builder.AddContent(22, "\n");
#line 37 "C:\Users\hp\Documents\NEU Subjects\Fall 2018\WebDev\FinalProject\Part3\ShoppingCart\ShoppingCart.Client\Pages\Index.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 38 "C:\Users\hp\Documents\NEU Subjects\Fall 2018\WebDev\FinalProject\Part3\ShoppingCart\ShoppingCart.Client\Pages\Index.cshtml"
            
Users usr ;
protected override async Task OnInitAsync()
{
    usr = await Http.GetJsonAsync<Users>("/api/Users/admin");
}

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
