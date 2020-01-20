#pragma checksum "C:\Users\hp\Documents\NEU Subjects\Fall 2018\WebDev\FinalProject\Part3\ShoppingCart\ShoppingCart.Client\Pages\EditProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f56e349fd67ec7a1fba7dc22c72a92e711f4ad04"
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

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/EditProduct/{productID}")]
    public class EditProduct : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 45 "C:\Users\hp\Documents\NEU Subjects\Fall 2018\WebDev\FinalProject\Part3\ShoppingCart\ShoppingCart.Client\Pages\EditProduct.cshtml"
 
    [Parameter]
    private string productID { get; set; }
    Products prod ;

    protected override async Task OnInitAsync()
    {
        prod = await Http.GetJsonAsync<Products>
            ("/api/Product/" + Convert.ToInt64(productID));
    }

    protected async Task UpdateProduct()
    {
        await Http.SendJsonAsync(HttpMethod.Put, "api/Product/" + Convert.ToInt64(productID) , prod);
        UriHelper.NavigateTo("/AdminHome");
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
