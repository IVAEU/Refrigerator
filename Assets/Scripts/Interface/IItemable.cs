using System.Collections.Generic;
using Utils;

public struct ItemInformation
{
    public readonly string ItemName;
    public readonly string ItemDescription;

    public ItemInformation(string name, string desc)
    {
        ItemName = name;
        ItemDescription = desc;
    }
}

public interface IItemable
{
    public ItemInformation ItemText
    {
        get;
    }
    
    public Dictionary<Define.Stat, VariableData> ItemData
    {
        get;
    }
    public int MaxStack
    {
        get;
    }
}