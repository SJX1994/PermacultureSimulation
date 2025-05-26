using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class System_Static_Player_Resource
{
    public static int money; // 玩家拥有的钱
    public static List<Base_Data> inventory; // 玩家库存
    public static event System.Action OnUpdateUI;
    public static void Invoke_OnUpdateUI()
    {
        OnUpdateUI?.Invoke();
    }
    // 根据标签计数
    public static int GetItemCountByTag(Base_Data.DataTags tag)
    {
        int count = 0;
        if (inventory == null) return count;
        foreach (var item in inventory)
        {
            if (item.dataTags == tag)
            {
                count++;
            }
        }
        return count;
    }
}
