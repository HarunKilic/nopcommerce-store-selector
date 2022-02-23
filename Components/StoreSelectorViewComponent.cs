using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widgets.StoreSelector.Components;

public class StoreSelectorViewComponent : NopViewComponent
{
    public StoreSelectorViewComponent()
    {
    }

    public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
    {
        return View("~/Plugins/Widgets.StoreSelector/Views/StoreSelector.cshtml");
    }
} 