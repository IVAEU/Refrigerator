using System;
using System.Collections;
using System.Collections.Generic;
using Items;
using UnityEngine;

public class Human : MonoBehaviour
{
    private Refrigerator _refrigerator;
 
    private void Start()
    {
        _refrigerator = new Refrigerator();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _refrigerator.AddItem(new Sword());
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _refrigerator.AddItem(new Elephant());
        }
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            foreach (var item in _refrigerator.ItemContain)
            {
                string itemStr = "[";
                itemStr += item.ItemData.ItemText.ItemName;
                itemStr += "]: ";
                itemStr += item.ItemData.ItemText.ItemDescription;
                itemStr += " (";
                itemStr += item.Count;
                itemStr += "/";
                itemStr += item.ItemData.MaxStack;
                itemStr += ")\n";
                
                foreach (var itemData in item.ItemData.ItemData)
                {
                    itemStr += itemData.Key + ": " + itemData.Value.VariableValue;
                }
                Debug.Log(itemStr);
            }
        }
    }
}
