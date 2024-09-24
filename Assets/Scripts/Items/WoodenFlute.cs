using System.Collections.Generic;
using Utils;
using UnityEngine;

namespace Items
{
    [CreateAssetMenu(menuName = "Item/WoodenFlute")]
    public class WoodenFlute : ScriptableObject, IItem, IBurnable, ISoundable
    {
        public ItemInformation ItemText { get; } = new ItemInformation("나무 피리", "좋은 소리는 아니지만 들을 만한 정도의 소리가 나온다.");
        public Dictionary<Define.Stat, VariableData> ItemData { get; }
        public int MaxStack { get; } = 1;
        public void Burn()
        {
            //불태우기
        }
        public void MakeSound()
        {
            //음악 소리 내기
        }
    }
}