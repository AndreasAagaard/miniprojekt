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
#line 1 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
using miniprojekt.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
using miniprojekt.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
using MongoDB.Bson;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Pages\Counter.razor"
       

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
