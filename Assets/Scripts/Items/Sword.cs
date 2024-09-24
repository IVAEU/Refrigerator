using System.Collections.Generic;
using Utils;
using UnityEngine;

namespace Items
{
    [CreateAssetMenu(menuName = "Item/Sword")]
    public class Sword : ScriptableObject, IItem
    {
        public ItemInformation ItemText { get; } = new ItemInformation("전설의 검", "전설적인 용사가 사용했던 검이다.");
        
        public Dictionary<Define.Stat, VariableData> ItemData { get; } = new()
        {
            { Define.Stat.Weight, new VariableData(Define.VariableType.Int, "10") },
            { Define.Stat.AttackPower, new VariableData(Define.VariableType.Int, "6") },
            { Define.Stat.Sharpness, new VariableData(Define.VariableType.Int, "2") },
            { Define.Stat.Durability, new VariableData(Define.VariableType.Float, "100.0") },
        };

        public int MaxStack { get; } = 10;
    }
}