using System.Collections.Generic;
using Nop.Core.Domain.Stores;
using Nop.Web.Framework.Models;

namespace Nop.Plugin.Widgets.StoreSelector.Models;

public record StoreSelectorModel : BaseNopModel
{
    public StoreSelectorModel()
    {
        AvailableStores = new List<Store>();
    }
    
    public IList<Store> AvailableStores { get; set; }

    public int CurrentStoreId { get; set; }
}