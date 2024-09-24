
using System.Collections.Generic;

public class ContainData
{
    public IItem ItemData;
    public int Count;

    public ContainData(IItem item, int c)
    {
        ItemData = item;
        Count = c;
    }
}