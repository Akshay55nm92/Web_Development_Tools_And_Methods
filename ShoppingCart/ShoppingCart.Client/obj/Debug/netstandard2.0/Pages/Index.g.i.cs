#pragma checksum "C:\Users\hp\Documents\NEU Subjects\Fall 2018\WebDev\FinalProject\Part3\ShoppingCart\ShoppingCart.Client\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d6389f441e03f806b24e91840eefb3a0d63a697"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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