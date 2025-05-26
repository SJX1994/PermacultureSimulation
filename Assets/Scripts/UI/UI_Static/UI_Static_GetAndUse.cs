using UnityEngine;
using UnityEngine.UI;

public static class UI_Static_GetAndUse 
{
    // 存储当前选中的按钮
    public static Button selectedButton;

    // 定义一个事件，当按钮选择变化时触发
    public static event System.Action<Button> OnButtonSelected;

    // 设置当前选中的按钮
    public static void SetSelectedButton(Button button)
    {
        selectedButton = button;
        OnButtonSelected?.Invoke(button); // 触发事件
        Debug.Log("当前选中的按钮: " + button.name);
    }

    // 获取当前选中的按钮
    public static Button GetSelectedButton()
    {
        return selectedButton;
    }
}
