#pragma checksum "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5663327c890d8afec50d58ae7acda4ab8e7f0ee"
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
#line 2 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
using miniprojekt.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>");
#nullable restore
#line 9 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.OpenElement(5, "thead");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "<th>Date</th>\n            ");
            __builder.AddMarkupContent(8, "<th>Temp. (C)</th>\n            ");
            __builder.AddMarkupContent(9, "<th>Temp. (F)</th>\n            ");
            __builder.OpenElement(10, "th");
            __builder.AddContent(11, 
#nullable restore
#line 21 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
                 forecasts

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n    ");
            __builder.OpenElement(13, "tbody");
#nullable restore
#line 25 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
         foreach (var forecast in forecasts)
        {
            Console.WriteLine(string.Join("\t", forecast));

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "tr");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 29 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
                     forecast.properties.cvr_navn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 30 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
                     forecast.properties.navn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "tr");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 34 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
             forecasts

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/Databasedesign/MongoDB_VSC/mini-shelter/miniprojekt/blazor/miniprojekt/miniprojekt/Client/Pages/FetchData.razor"
       
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
