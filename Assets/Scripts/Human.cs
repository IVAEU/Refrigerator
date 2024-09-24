using System;
using System.Collections;
using System.Collections.Generic;
using Items;
using UnityEngine;
using Utils;




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
            _refrigerator.AddItem(ScriptableObject.CreateInstance<Sword>());
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _refrigerator.AddItem(ScriptableObject.CreateInstance<Elephant>());
        }
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            foreach (var item in _refrigerator.ItemContain)
            {
                string str =
                    $"[{item.ItemData.ItemText.ItemName}]: " +
                    $"{item.ItemData.ItemText.ItemDescription} " +
                    $"({item.Count}/{item.ItemData.MaxStack})\n";
                
                foreach (var itemData in item.ItemData.ItemData)
                {
                    str += $"|{itemData.Key}:{itemData.Value.VariableValue}";
                }

                str += "|";
                Debug.Log(str);
            }
        }
    }
}
