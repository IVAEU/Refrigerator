
using System.Collections.Generic;

public class ContainData
{
    public IItemable ItemData;
    public int Count;

    public ContainData(IItemable item, int c)
    {
        ItemData = item;
        Count = c;
    }
}