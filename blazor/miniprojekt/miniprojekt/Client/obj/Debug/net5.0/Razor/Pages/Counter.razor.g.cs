#pragma checksum "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17d47ded64fd07b35d88f6bfac84cd77e0c3d960"
// <auto-generated/>
#pragma warning disable 1591
namespace miniprojekt.Client.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using miniprojekt.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using miniprojekt.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
using miniprojekt.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
using miniprojekt.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
using MongoDB.Bson;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
using MongoDB.Driver;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/shelterbooking")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Shelteroversigt</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Her kan du se alle shelters og foretage bookinger.<br><b>Bemærk!</b> En booking er gyldig fra kl. 12.00 på startdatoen til kl. 12.00 på slutdatoen.</p>");
#nullable restore
#line 14 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
 if (shelters == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 17 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, @"<head><title>Shelter booking</title>
        <style>
            .tableFixHead {
                overflow-y: auto;
                height: 450px;
                overflow-x: auto;
                width: 1000px;
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
            __builder.AddMarkupContent(8, "<thead><tr><th>Navn</th>\r\n                        <th>Kommune</th>\r\n                        <th>Antal pladser</th>\r\n                        <th>Book</th></tr></thead>\r\n                ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 68 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
                     foreach (var shelter in shelters)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 71 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
                                 shelter.properties.navn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                            ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 72 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
                                 shelter.properties.cvr_navn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                            ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 73 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
                                 shelter.properties.antal_pl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                            ");
            __builder.OpenElement(20, "td");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "class", "btn btn-outline-dark btn-sm");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
                                                                                                    () => OpenBookDialog(shelter._id, shelter.properties.navn)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Book");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 82 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
     if (BookDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<miniprojekt.Client.Components.ModalDialog>(26);
            __builder.AddAttribute(27, "Title", "Du er ved at booke et shelter");
            __builder.AddAttribute(28, "Text", "Udfyld alle felter og bekræft booking ved at trykke OK");
            __builder.AddAttribute(29, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 84 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
                                                                                                                                                                 OnBookDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 85 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
     

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_04.11\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
       

    private shelter[] shelters;

    public bool BookDialogOpen { get; set; }

    private void OnBookDialogClose(bool accepted)
    {
        BookDialogOpen = false;
        StateHasChanged();

    }

    private void OpenBookDialog(string id, string navn)
    {

        BookDialogOpen = true;
        ModalDialog.testBook.shelter_id = id;
        ModalDialog.testBook.shelter_navn = navn;
        StateHasChanged();
    }

    protected override async Task OnInitializedAsync()
    {
        shelters = await Http.GetFromJsonAsync<shelter[]>("Shelter");

    }






#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
