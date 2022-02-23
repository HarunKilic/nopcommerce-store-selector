using System.Collections.Generic;
using System.Threading.Tasks;
using Nop.Services.Cms;
using Nop.Services.Plugins;
using Nop.Web.Framework;
using Nop.Web.Framework.Infrastructure;
using Nop.Web.Framework.Menu;

namespace Nop.Plugin.Widgets.StoreSelector;

public class StoreSelectorPlugin : BasePlugin, IWidgetPlugin
{
    public bool HideInWidgetList => false;

    public Task<IList<string>> GetWidgetZonesAsync()
    {
        return Task.FromResult<IList<string>>(new List<string> {PublicWidgetZones.HeaderSelectors});
    }

    public string GetWidgetViewComponentName(string widgetZone)
    {
        return OrganizationChooserDefaults.VIEW_COMPONENT;
    }
}