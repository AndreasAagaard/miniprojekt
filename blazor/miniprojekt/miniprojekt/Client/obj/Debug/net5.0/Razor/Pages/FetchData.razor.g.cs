#pragma checksum "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "098afdc40034c1ea94f83cc3e501a8ef1884499d"
// <auto-generated/>
#pragma warning disable 1591
namespace miniprojekt.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using miniprojekt.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using miniprojekt.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\FetchData.razor"
using miniprojekt.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bookingoversigt")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Bookingoversigt</h1>\r\n\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<p>Her ses alle bookinger af shelters.</p>");
#nullable restore
#line 13 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\FetchData.razor"
 if (bookings == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 16 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, @"<head><title>Booking</title>
        <style>
            .tableFixHead {
                overflow-y: auto;
                height: 450px;
                overflow-x: auto;
                width: 1200px;
                border-radius: 0.5%;
            }

                .tableFixHead thead th {
                    position: sticky;
                    top: 0;
                }

            table {
                border-collapse: collapse;
                width: 100%;
            }

            td {
                padding: 8px 16px;
                border: 1px solid #ccc;
                background: #91b247;
            }

            th {
                padding: 8px 16px;
                border: 1px solid #ccc;
                background: #597c2b;
            }
        </style></head>");
            __builder.OpenElement(4, "body");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "tableFixHead");
            __builder.OpenElement(7, "table");
            __builder.AddMarkupContent(8, @"<thead><tr><th>Startdate</th>
                        <th>Slutdato</th>
                        <th>Antal personer</th>
                        <th>Navn</th>
                        <th>Telefonnummer</th>
                        <th>Email</th>
                        <th>Shelter navn</th>
                        <th>Slet Booking</th></tr></thead>
                ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 70 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\FetchData.razor"
                     foreach (var booking in bookings)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 73 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\FetchData.razor"
                                 booking.startdate.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                            ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 74 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\FetchData.razor"
                                 booking.slutdate.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                            ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 75 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\FetchData.razor"
                                 booking.antal_pers

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                            ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 76 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\FetchData.razor"
                                 booking.navn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 77 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\FetchData.razor"
                                 booking.telefon

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 78 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\FetchData.razor"
                                 booking.email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 79 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\FetchData.razor"
                                 booking.shelter_navn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.OpenElement(32, "td");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "class", "btn btn-outline-danger btn-sm");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\FetchData.razor"
                                                                                                      () => deleteControl(booking)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Slet Booking");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 83 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\FetchData.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 88 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\FetchData.razor"
       
    private shelter shelly;
    private Booking[] bookings;
    public Booking testBook = new() { booking_date = DateTime.Now };

    private async void deleteControl(Booking book)
    {
        await deleteBooking(book);
        uriHelper.NavigateTo(uriHelper.Uri, forceLoad: true);
    }

    protected override async Task OnInitializedAsync()
    {
        bookings = await Http.GetFromJsonAsync<Booking[]>("Booking");
    }

    public async Task getShelter(string id)
    {
        shelly = await Http.GetFromJsonAsync<shelter>($"Shelter/{id}");

    }

    protected async Task deleteBooking(Booking book)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Er du sikker p??, at du vil slette bookingen?");
        if (confirmed)
        {
            await Http.DeleteAsync($"Booking/{book._id}");
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
