// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace miniprojekt.Client.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_ny\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_ny\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_ny\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_ny\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_ny\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_ny\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_ny\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_ny\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_ny\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using miniprojekt.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_ny\miniprojekt\blazor\miniprojekt\miniprojekt\Client\_Imports.razor"
using miniprojekt.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_ny\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_ny\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "C:\Users\linek\Documents\Erhvervsakademi Aarhus\2. semester\Datebasedesign\Miniprojekt_ny\miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
       
    //List<string> shelterliste = new List<string>() { "Shelter1", "Shelter2", "Shelter3" };


    private shelter[] forecasts;

    public bool BookDialogOpen { get; set; }

    private void OnBookDialogClose(bool accepted)
    {
        BookDialogOpen = false;
        StateHasChanged();
    }

    private void OpenBookDialog()
    {
        BookDialogOpen = true;
        StateHasChanged();
    }

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
