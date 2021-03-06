#pragma checksum "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7112ef46d7db55632cd7a3969f92d4c3c54b23f9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TextbookFinder.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\_Imports.razor"
using TextbookFinder.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/textbooks/edit/{id:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/textbooks/create")]
    public partial class Editor : OwningComponentBase<ITextbookRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\Editor.razor"
       

    public ITextbookRepository Repository => Service;

    [Inject]
    public NavigationManager NavManager { get; set; }

    [Parameter]
    public int Id { get; set; } = 0;

    public Textbooks Textbook { get; set; } = new Textbooks();

    protected override void OnParametersSet()
    {
        if (Id != 0)
        {
            Textbook = Repository.Textbook.FirstOrDefault(p => p.TextbookId == Id);
        }
    }

    public void SaveTextbook()
    {
        if (Id == 0)
        {
            Repository.CreateTextbook(Textbook);
        }
        else
        {
            Repository.SaveTextbook(Textbook);
        }
        NavManager.NavigateTo("/admin/textbook");
    }

    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Create" : "Edit";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
