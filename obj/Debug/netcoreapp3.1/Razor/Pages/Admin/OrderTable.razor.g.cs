#pragma checksum "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\OrderTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57f378faa5eb642a3ea0df337bced1805d525966"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class OrderTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "th");
            __builder.AddAttribute(7, "colspan", "5");
            __builder.AddAttribute(8, "class", "text-center");
            __builder.AddContent(9, 
#nullable restore
#line 3 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\OrderTable.razor"
                                                 TableTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "tbody");
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 6 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\OrderTable.razor"
         if (Orders?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\OrderTable.razor"
             foreach (Order o in Orders)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "              ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n                  ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 11 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\OrderTable.razor"
                       o.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 11 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\OrderTable.razor"
                                       o.Zip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "<th>Textbooks</th>");
            __builder.AddMarkupContent(22, "<th>Quantity</th>\r\n                  ");
            __builder.OpenElement(23, "td");
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\OrderTable.razor"
                                       e => OrderSelected.InvokeAsync(o.OrderId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.AddContent(29, 
#nullable restore
#line 15 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\OrderTable.razor"
                         ButtonLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                   ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n              ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 19 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\OrderTable.razor"
                   foreach (CartLine line in o.Lines)
                   {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "                     ");
            __builder.OpenElement(35, "tr");
            __builder.AddMarkupContent(36, "\r\n                      <td colspan=\"2\"></td>\r\n                      ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, " ");
            __builder.AddContent(39, 
#nullable restore
#line 23 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\OrderTable.razor"
                            line.Textbook.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 23 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\OrderTable.razor"
                                                         line.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                      <td></td>\r\n                     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 26 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\OrderTable.razor"
                   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\OrderTable.razor"
                    
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\OrderTable.razor"
             
        } else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "            ");
            __builder.AddMarkupContent(45, "<tr><td colspan=\"5\" class=\"text-center\">No Orders</td></tr>\r\n");
#nullable restore
#line 30 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\OrderTable.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\g2c10\Documents\source\repos\TextbookFinderV2\Pages\Admin\OrderTable.razor"
       
    [Parameter]
    public string TableTitle { get; set; } = "Orders";

    [Parameter]
    public IEnumerable<Order> Orders { get; set; }

    [Parameter]
    public string ButtonLabel { get; set; } = "Ship";

    [Parameter]
    public EventCallback<int> OrderSelected { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
