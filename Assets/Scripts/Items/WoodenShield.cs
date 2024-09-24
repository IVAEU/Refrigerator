using System.Collections.Generic;
using Utils;
using UnityEngine;

namespace Items
{
    [CreateAssetMenu(menuName = "Item/WoodenShield")]
    public class WoodenShield : ScriptableObject, IItem, IBurnable
    {
        public ItemInformation ItemText { get; }
        public Dictionary<Define.Stat, VariableData> ItemData { get; }
        public int MaxStack { get; }
        public void Burn()
        {
            //불태우기
        }
    }
}