using Nop.Core;

namespace Nop.Plugin.Widgets.StoreSelector;

public class StoreSelectorDefaults
{
    public static string SystemName => "Widgets.StoreSelector";

    public static string UserAgent => $"nopcommerce-{NopVersion.CURRENT_VERSION}";

    public static string ConfigurationRouteName => "Plugin.Widgets.StoreSelector.Configure";

    public static string ChangeStoreRouteName => "Plugin.Widgets.StoreSelector.ChangeStore";
    
    public static string StoreIdAttribute => "StoreId";
    
    public const string VIEW_COMPONENT = "StoreSelector";
}
