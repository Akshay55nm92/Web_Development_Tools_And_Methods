#pragma checksum "C:\Users\hp\Documents\NEU Subjects\Fall 2018\WebDev\FinalProject\Part3\ShoppingCart\ShoppingCart.Client\Pages\AdminHome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21225b3cf2e49a2d6269598352b671e971666430"
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

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/AdminHome")]
    public class AdminHome : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 50 "C:\Users\hp\Documents\NEU Subjects\Fall 2018\WebDev\FinalProject\Part3\ShoppingCart\ShoppingCart.Client\Pages\AdminHome.cshtml"
            
    public Products[] prodList;
    public Products[] CartList;

    public int qty { get; set; }


    protected override async Task OnInitAsync()
    {
        prodList = await Http.GetJsonAsync<Products[]>("/api/Product/");

    }

    public void EditProduct(Products p)
    {
        UriHelper.NavigateTo("/EditProduct/" + p.Id);
    }

    protected async Task DeleteProduct(Products p)
    {
        await Http.SendJsonAsync(HttpMethod.Delete, "api/Product/" + Convert.ToInt64(p.Id), p);
        this.StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
