using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class System_Player_Trade : MonoBehaviour
{
    public string playerName; // 玩家名称
    void Start()
    {
        System_Static_Player_Resource.money = 50;
        System_Static_Player_Resource.inventory = new();
    }
    // 购买商品
    public bool BuyItem(Base_Data item)
    {
        if (System_Static_Player_Resource.money >= item.Price)
        {
            System_Static_Player_Resource.money -= item.Price; // 扣除商品价格
            System_Static_Player_Resource.inventory.Add(item);  // 将商品添加到库存
            Debug.Log($"{playerName} 购买了 {item.name}，剩余金钱: {System_Static_Player_Resource.money}");
            System_Static_Player_Resource.Invoke_OnUpdateUI();
            return true;
        }
        else
        {
            Debug.Log($"{playerName} 没有足够的钱购买 {item.name}");
            return false;
        }
    }

    // 卖出商品
    public bool SellItem(Base_Data item)
    {
        if (System_Static_Player_Resource.inventory.Contains(item))
        {
            System_Static_Player_Resource.inventory.Remove(item); // 从库存中移除商品
            System_Static_Player_Resource.money += item.Price;     // 增加商品价格
            Debug.Log($"{playerName} 卖出了 {item.name}，当前金钱: {System_Static_Player_Resource.money}");
            System_Static_Player_Resource.Invoke_OnUpdateUI();
            return true;
        }
        else
        {
            Debug.Log($"{playerName} 没有 {item.name} 在库存中");
            return false;
        }
    }
    
}
