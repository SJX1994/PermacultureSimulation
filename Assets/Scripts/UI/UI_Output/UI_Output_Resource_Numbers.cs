using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Output_Resource_Numbers : MonoBehaviour
{
    public Image btn_Money;
    public Image btn_Physical;
    public Image btn_Society;
    public Image btn_Spirit;
    private TextMeshProUGUI text_Money;
    private TextMeshProUGUI text_Physical;
    private TextMeshProUGUI text_Society;
    private TextMeshProUGUI text_Spirit;

    void Start()
    {
        text_Money = btn_Money.GetComponentInChildren<TextMeshProUGUI>();
        text_Physical = btn_Physical.GetComponentInChildren<TextMeshProUGUI>();
        text_Society = btn_Society.GetComponentInChildren<TextMeshProUGUI>();
        text_Spirit = btn_Spirit.GetComponentInChildren<TextMeshProUGUI>();
        Trade_Data.OnUpdateUI += Update_UI;
        Invoke(nameof(Update_UI),0.1f);
    }
    void OnDestroy()
    {
        Trade_Data.OnUpdateUI -= Update_UI;
    }
    void Update_UI()
    {
        if (text_Spirit == null) return;
        text_Money.text = Trade_Data.money.ToString();
        text_Physical.text = Trade_Data.GetItemCountByTag(Base_Data.DataTags.Physical).ToString();
        text_Society.text = Trade_Data.GetItemCountByTag(Base_Data.DataTags.Society).ToString();
        text_Spirit.text = Trade_Data.GetItemCountByTag(Base_Data.DataTags.Spirit).ToString();
    }
}