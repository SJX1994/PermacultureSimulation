using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Input_GetAndUse : MonoBehaviour
{
    public Button Button_Get;
    public Button Button_Use;
    private enum ActionType{Get,Use}
    private ActionType type;
    public System_Player_Trade system_Player_Trade;
    void Start()
    {
        Button_Get.onClick.AddListener(() => OnButtonClicked(ActionType.Get));
        Button_Use.onClick.AddListener(() => OnButtonClicked(ActionType.Use));
        UI_Input_Data.OnButtonSelected += UpdateUI;
        if (system_Player_Trade == null)
        {
            system_Player_Trade = GameObject.FindObjectOfType<System_Player_Trade>();
        }
    }
    void OnDestroy()
    {
        UI_Input_Data.OnButtonSelected -= UpdateUI;
    }
    void OnButtonClicked(ActionType type)
    {
        this.type = type;
        Button currentButton = UI_Input_Data.GetSelectedButton();
        if (currentButton == null) return;
        Debug.Log(currentButton.name);
        switch (type)
        {
            case ActionType.Get:
                Base_Data base_Data_Get = currentButton.GetComponent<Component_Base>().base_Data;
                system_Player_Trade.SellItem(base_Data_Get);
                break;
            case ActionType.Use:
                Base_Data base_Data_Use = currentButton.GetComponent<Component_Base>().base_Data;
                system_Player_Trade.BuyItem(base_Data_Use);
                break;
        }
    }
    private void UpdateUI(Button selectedButton)
    {
        Base_Data data = selectedButton.GetComponent<Component_Base>().base_Data;
        Button_Get.GetComponentInChildren<TextMeshProUGUI>().text = data.Get;
        Button_Use.GetComponentInChildren<TextMeshProUGUI>().text = data.Use;
    }
   
}
