// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace InternshipProject.Client.CustomComponents.ModalComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Anil\Documents\GitHub\internship-project\InternshipProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anil\Documents\GitHub\internship-project\InternshipProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anil\Documents\GitHub\internship-project\InternshipProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anil\Documents\GitHub\internship-project\InternshipProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anil\Documents\GitHub\internship-project\InternshipProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anil\Documents\GitHub\internship-project\InternshipProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anil\Documents\GitHub\internship-project\InternshipProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anil\Documents\GitHub\internship-project\InternshipProject\Client\_Imports.razor"
using InternshipProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anil\Documents\GitHub\internship-project\InternshipProject\Client\_Imports.razor"
using InternshipProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Anil\Documents\GitHub\internship-project\InternshipProject\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Anil\Documents\GitHub\internship-project\InternshipProject\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Anil\Documents\GitHub\internship-project\InternshipProject\Client\_Imports.razor"
using InternshipProject.Client.CustomComponents.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Anil\Documents\GitHub\internship-project\InternshipProject\Client\_Imports.razor"
using InternshipProject.Client.CustomComponents.ModalComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Anil\Documents\GitHub\internship-project\InternshipProject\Client\_Imports.razor"
using InternshipProject.Client.Utils;

#line default
#line hidden
#nullable disable
    public partial class ShowMessagePopupComponent : BaseModalComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Anil\Documents\GitHub\internship-project\InternshipProject\Client\CustomComponents\ModalComponents\ShowMessagePopupComponent.razor"
        
    public async override Task SetParametersAsync(ParameterView parameters)
    {
        Message = parameters.GetValueOrDefault<String>("Message") ?? "No Message";
        OkText = "OK";
        await base.SetParametersAsync(parameters);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
