#pragma checksum "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a866247e285bdf44613b522c5c8886eb6268e8a8"
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
#line 1 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using miniprojekt.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/_Imports.razor"
using miniprojekt.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/Counter.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/Counter.razor"
using miniprojekt.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/shelterbooking")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Shelteroversigt</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>Her kan du se alle shelters og foretage bookinger.<br><b>Bemærk!</b> En booking er gyldig fra kl. 12.00 på startdatoen til kl. 12.00 på slutdatoen.</p>");
#nullable restore
#line 10 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/Counter.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/Counter.razor"
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
            __builder.OpenElement(8, "thead");
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "<th>Navn</th>\n                        ");
            __builder.AddMarkupContent(11, "<th>Cvr-navn</th>\n                        ");
            __builder.AddMarkupContent(12, "<th>Kommunekode</th>\n                        ");
            __builder.AddMarkupContent(13, "<th>Antal pladser</th>\n                        ");
            __builder.AddMarkupContent(14, "<th>Koordinater</th>\n                        ");
            __builder.OpenElement(15, "th");
            __builder.AddContent(16, 
#nullable restore
#line 61 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/Counter.razor"
                             forecasts

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 65 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/Counter.razor"
                     foreach (var forecast in forecasts)
                    {
                        Console.WriteLine(string.Join("\t", forecast));

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 69 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/Counter.razor"
                                 forecast.properties.navn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                            ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 70 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/Counter.razor"
                                 forecast.properties.cvr_navn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                            ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 71 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/Counter.razor"
                                 forecast.properties.kommunekode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                            ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 72 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/Counter.razor"
                                 forecast.properties.antal_pl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                            ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 73 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/Counter.razor"
                                 forecast.geometry.coordinates

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/Counter.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "tr");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 77 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/Counter.razor"
                             forecasts

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 83 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/Counter.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/Counter.razor"
       
    //List<string> shelterliste = new List<string>() { "Shelter1", "Shelter2", "Shelter3" };


    private shelter[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<shelter[]>("WeatherForecast");


    }
    Booking testBook = new Booking(DateTime.Now, DateTime.Now.AddDays(1), 5, "Placeholder", "sadjsaBruger");





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
