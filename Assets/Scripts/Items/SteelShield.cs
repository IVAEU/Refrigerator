using System.Collections.Generic;
using UnityEngine;
using Utils;

namespace Items
{
    [CreateAssetMenu(menuName = "Item/SteelShield")]
    public class SteelShield : ScriptableObject, IItem, ISoundable
    {
        public ItemInformation ItemText { get; }
        public Dictionary<Define.Stat, VariableData> ItemData { get; }
        public int MaxStack { get; }
        public void MakeSound()
        {
            //깡깡 소리내기
        }
    }
}