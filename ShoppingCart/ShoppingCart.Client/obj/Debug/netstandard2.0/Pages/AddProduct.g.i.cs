#pragma checksum "C:\Users\hp\Documents\NEU Subjects\Fall 2018\WebDev\FinalProject\Part3\ShoppingCart\ShoppingCart.Client\Pages\AddProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef22902f4b22ee5c12f2bea002e3c08664d1daa1"
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
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(AdminMainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/AddProduct")]
    public class AddProduct : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 20 "C:\Users\hp\Documents\NEU Subjects\Fall 2018\WebDev\FinalProject\Part3\ShoppingCart\ShoppingCart.Client\Pages\AddProduct.cshtml"
 
    Products prod = new Products();


    protected async Task CreateProduct()
    {
        Random rn = new Random();
        prod.Id = rn.Next(0, Int32.MaxValue);
        await Http.SendJsonAsync(HttpMethod.Post, "/api/Product", prod);
        UriHelper.NavigateTo("/AdminHome");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
