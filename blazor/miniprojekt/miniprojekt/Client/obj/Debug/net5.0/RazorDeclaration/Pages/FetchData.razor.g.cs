// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\FetchData.razor"
       
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

    public Task<HttpResponseMessage> postUser(Booking booking)
    {
        return Http.PostAsJsonAsync<Booking>("Booking", booking);

    }

    public async Task getShelter(string id)
    {
        shelly = await Http.GetFromJsonAsync<shelter>($"Shelter/{id}");

    }

    protected async Task deleteBooking(Booking book)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
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
