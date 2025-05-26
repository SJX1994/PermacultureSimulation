using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class System_Player_Trade : MonoBehaviour
{
    
    System_Player_Resource_Manager system_Player_Resource_Manager;
    void Start()
    {
        system_Player_Resource_Manager = transform.GetComponent<System_Player_Resource_Manager>();
        Trade_Data.money = 50;
        Trade_Data.inventory = new();
    }
    // 购买商品
    public bool BuyItem(Base_Data item)
    {
        return system_Player_Resource_Manager.AddResource(item);
    }

    // 卖出商品
    public void SellItem(Base_Data item)
    {
        system_Player_Resource_Manager.ConvertLaborToMoney(item);
    }
    
}
