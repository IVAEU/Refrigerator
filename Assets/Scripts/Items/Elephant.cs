using System.Collections.Generic;
using Utils;
using UnityEngine;

namespace Items
{
    [CreateAssetMenu(menuName = "Item/Elephant")]
    public class Elephant : ScriptableObject, IItem
    {
        public ItemInformation ItemText { get; } = new ItemInformation("코끼리", "냉장고에 넣어보자");

        public Dictionary<Define.Stat, VariableData> ItemData { get; } = new()
        {
            { Define.Stat.Weight, new VariableData(Define.VariableType.Int, "130") },
            { Define.Stat.Luck, new VariableData(Define.VariableType.Int, "50") },
            { Define.Stat.Speed, new VariableData(Define.VariableType.Int, "10") },
        };

        public int MaxStack { get; } = 10;
    }
}