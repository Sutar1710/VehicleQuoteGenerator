#pragma checksum "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\Pages\QuoteDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc22a751c5744149f131b6c5a4248f56b71fd688"
// <auto-generated/>
#pragma warning disable 1591
namespace VehicleQuote.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\_Imports.razor"
using VehicleQuote.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\_Imports.razor"
using VehicleQuote.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\Pages\QuoteDisplay.razor"
using VehicleQuote.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/quote-display")]
    public partial class QuoteDisplay : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Extract Data</h2>\r\n");
            __builder.AddMarkupContent(1, "<p>Enter your username to extract data:</p>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-group");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "placeholder", "Enter your Email ID");
            __builder.AddAttribute(9, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\Pages\QuoteDisplay.razor"
                               username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "text-center");
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-md-10");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn btn-primary");
            __builder.AddAttribute(21, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\Pages\QuoteDisplay.razor"
                                                  ExtractData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Extract Data");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n");
#nullable restore
#line 19 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\Pages\QuoteDisplay.razor"
 if (userList != null && userList.Count > 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "    ");
            __builder.AddMarkupContent(27, "<h3>Vehicle Quote Data</h3>\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "table-responsive");
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "table");
            __builder.AddAttribute(32, "class", "table table-striped table-bordered");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.AddMarkupContent(34, @"<thead>
                <tr>
                    <th>Username</th>
                    <th>Vehicle Age</th>
                    <th>Vehicle Make</th>
                    <th>Vehicle Model</th>
                    <th>Vehicle Coverage</th>
                    <th>Quote</th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(35, "tbody");
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 35 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\Pages\QuoteDisplay.razor"
                 foreach (var user in userList)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                    ");
            __builder.OpenElement(38, "tr");
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "td");
#nullable restore
#line 38 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\Pages\QuoteDisplay.razor"
__builder.AddContent(41, user.username);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "td");
#nullable restore
#line 39 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\Pages\QuoteDisplay.razor"
__builder.AddContent(44, user.vehicleage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "td");
#nullable restore
#line 40 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\Pages\QuoteDisplay.razor"
__builder.AddContent(47, user.vehiclemake);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "td");
#nullable restore
#line 41 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\Pages\QuoteDisplay.razor"
__builder.AddContent(50, user.vehiclemodel);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.OpenElement(52, "td");
#nullable restore
#line 42 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\Pages\QuoteDisplay.razor"
__builder.AddContent(53, user.vehiclecoverage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.OpenElement(55, "td");
#nullable restore
#line 43 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\Pages\QuoteDisplay.razor"
__builder.AddContent(56, user.formula);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 45 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\Pages\QuoteDisplay.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 49 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\Pages\QuoteDisplay.razor"
}
else if (userList != null && userList.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "    ");
            __builder.AddMarkupContent(64, "<p><h4>Data not found for the provided Username.</h4></p>\r\n");
#nullable restore
#line 53 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\Pages\QuoteDisplay.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\alaxmansutar\OneDrive - DXC Production\Desktop\Vehicle Quote Generator\VehicleQuote\Client\Pages\QuoteDisplay.razor"
       
    private List<User> userList;
    private string username;

    private async Task ExtractData()
    {
        userList = await Http.GetFromJsonAsync<List<User>>($"api/user?username={username}");
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
