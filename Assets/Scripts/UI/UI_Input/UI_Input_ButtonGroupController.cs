using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Input_ButtonGroupController : MonoBehaviour
{
    public Button[] buttons; // 存储按钮的数组
    private Button selectedButton; // 存储当前选中的按钮

    // Start is called before the first frame update
    void Start()
    {
        // 添加按钮按钮点击事件
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => OnButtonClicked(button));
        }
    }

    private void OnButtonClicked(Button button)
    {
        if (selectedButton != null)
        {
            // 如果有按钮被选中，取消选中状态
            DeselectButton(selectedButton);
        }

        // 选中当前点击的按钮
        SelectButton(button);
    }
    private void SelectButton(Button button)
    {
        button.GetComponent<Image>().color = Color.green; // 可选：改变按钮颜色或添加其他视觉效果
        selectedButton = button; // 设置为选中的按钮
        Debug.Log("Selected button: " + button.name); // 记录选中状态
        // 使用静态类设置当前选中的按钮
        UI_Static_GetAndUse.SetSelectedButton(button);

    }

    private void DeselectButton(Button button)
    {
        button.GetComponent<Image>().color = Color.white; // 恢复按钮的原始颜色
    }
}
