#pragma checksum "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Components\ModalDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71765bfc64424618a1b9490686731941432d7ddb"
// <auto-generated/>
#pragma warning disable 1591
namespace miniprojekt.Client.Components
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
    public partial class ModalDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show");
            __builder.AddAttribute(2, "id", "myModal");
            __builder.AddAttribute(3, "style", "display:block; background-color: rgba(10,10,10,.8);");
            __builder.AddAttribute(4, "aria-modal", "true");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.OpenElement(12, "h4");
            __builder.AddAttribute(13, "class", "modal-title");
            __builder.AddContent(14, 
#nullable restore
#line 7 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Components\ModalDialog.razor"
                                         Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "class", "close");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Components\ModalDialog.razor"
                                                               ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "×");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "modal-body");
            __builder.OpenElement(24, "p");
            __builder.AddContent(25, 
#nullable restore
#line 11 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Components\ModalDialog.razor"
                    Text

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(28);
            __builder.AddAttribute(29, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Components\ModalDialog.razor"
                                  testBook

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Components\ModalDialog.razor"
                                                            BookShelter

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(32);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(34);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                    ");
                __builder2.OpenElement(36, "p");
                __builder2.OpenElement(37, "label");
                __builder2.AddMarkupContent(38, "\r\n                            Indtast Navn:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Components\ModalDialog.razor"
                                                     testBook.navn

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => testBook.navn = __value, testBook.navn))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => testBook.navn));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                    ");
                __builder2.OpenElement(44, "p");
                __builder2.OpenElement(45, "label");
                __builder2.AddMarkupContent(46, "\r\n                            Indtast Telefonnr:\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Components\ModalDialog.razor"
                                                     testBook.telefon

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => testBook.telefon = __value, testBook.telefon))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => testBook.telefon));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                    ");
                __builder2.OpenElement(52, "p");
                __builder2.OpenElement(53, "label");
                __builder2.AddMarkupContent(54, "\r\n                            Indtast Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(55);
                __builder2.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Components\ModalDialog.razor"
                                                     testBook.email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => testBook.email = __value, testBook.email))));
                __builder2.AddAttribute(58, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => testBook.email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                    ");
                __builder2.OpenElement(60, "p");
                __builder2.OpenElement(61, "label");
                __builder2.AddMarkupContent(62, "\r\n                            Antal Personer:&nbsp;&nbsp;&nbsp;\r\n                            ");
                __Blazor.miniprojekt.Client.Components.ModalDialog.TypeInference.CreateInputNumber_0(__builder2, 63, 64, 
#nullable restore
#line 36 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Components\ModalDialog.razor"
                                                       testBook.antal_pers

#line default
#line hidden
#nullable disable
                , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => testBook.antal_pers = __value, testBook.antal_pers)), 66, () => testBook.antal_pers);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                    ");
                __builder2.OpenElement(68, "p");
                __builder2.OpenElement(69, "label");
                __builder2.AddMarkupContent(70, "\r\n                            Startdato:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n                            ");
                __Blazor.miniprojekt.Client.Components.ModalDialog.TypeInference.CreateInputDate_1(__builder2, 71, 72, 
#nullable restore
#line 42 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Components\ModalDialog.razor"
                                                     testBook.startdate

#line default
#line hidden
#nullable disable
                , 73, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => testBook.startdate = __value, testBook.startdate)), 74, () => testBook.startdate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                    ");
                __builder2.OpenElement(76, "p");
                __builder2.OpenElement(77, "label");
                __builder2.AddMarkupContent(78, "\r\n                            Slutdato:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n                            ");
                __Blazor.miniprojekt.Client.Components.ModalDialog.TypeInference.CreateInputDate_2(__builder2, 79, 80, 
#nullable restore
#line 48 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Components\ModalDialog.razor"
                                                     testBook.slutdate

#line default
#line hidden
#nullable disable
                , 81, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => testBook.slutdate = __value, testBook.slutdate)), 82, () => testBook.slutdate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                    ");
                __builder2.AddMarkupContent(84, "<div class=\"modal-footer\"><button class=\"btn btn-primary\" type=\"submit\">Submit</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\emili\Desktop\Skole\2Semester\Miniprojekt\blazor\miniprojekt\miniprojekt\Client\Components\ModalDialog.razor"
      
    [Parameter]
    public string Title { get; set; }
    [Parameter]
    public string Text { get; set; }
    [Parameter]
    public EventCallback<bool> OnClose { get; set; }

    private Task ModalCancel()
    {
        return OnClose.InvokeAsync(false);
    }

    private Task ModalOk()
    {
        return OnClose.InvokeAsync(true);
    }


    public static Booking testBook = new() { booking_date = DateTime.Now };
    private Task BookShelter()
    {
        postUser(testBook);
        return OnClose.InvokeAsync(true);
    }

    public Task<HttpResponseMessage> postUser(Booking booking)
    {
        return Http.PostAsJsonAsync<Booking>("Booking", booking);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.miniprojekt.Client.Components.ModalDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591