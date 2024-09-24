using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Utils.Define;

public class Refrigerator
{
    public readonly List<ContainData> ItemContain = new();

    private bool ContainsItem(IItem inputItem, out List<ContainData> outputItems)
    {
        outputItems = new List<ContainData>();
        foreach (ContainData containItem in ItemContain)
        {
            if (containItem.ItemData.ItemText.ItemName == inputItem.ItemText.ItemName)
            {
                outputItems.Add(containItem);
            }
        }

        return outputItems.Count > 0;
    }
    
    public int GetItemCount<T>(T item) where T : IItem
    {
        ContainsItem(item, out List<ContainData> data);
        return data.Count;
    }

    public T AddItem<T>(T item) where T : IItem
    {
        if (ContainsItem(item, out List<ContainData> data))
        {
            foreach (var d in data)
            {
                if (d.Count < d.ItemData.MaxStack)
                {
                    d.Count++;
                    return item;
                }
            }
        }

        ItemContain.Add(new ContainData(item, 1));
        return item;
    }
    
    public T RemoveItem<T>(T item) where T : IItem
    {
        if (ContainsItem(item, out List<ContainData> data))
        {
            foreach (var d in data)
            {
                d.Count--;
                if (d.Count == 0)
                {
                    ItemContain.Remove(d);
                }
                return item;
            }
        }

        return item;
    }
}
