using tad_amnathrig.Models;

namespace tad_amnathrig.Models;

public class Item
{
    public int ItemId { get; set; }

    public List<ItemProperty>? Properties {get; set;}
}