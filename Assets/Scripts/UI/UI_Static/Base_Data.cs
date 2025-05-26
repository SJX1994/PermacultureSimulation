using UnityEngine;
[CreateAssetMenu(fileName = "Base_Data_", menuName = "Data/MyData")]
public class Base_Data : ScriptableObject
{
    [Header("显示名称")]
    public string Name;
    [Header("消耗体力")]
    public int Cost_PhysicalStrength;
    [Header("消耗精神")]
    public int Cost_MentalExhaustion;
    [Header("消耗物资")]
    public int Cost_MaterialConsumption;
    [Header("---金钱---")]
    public int Price;
    [Header("获取体力")]
    public int Get_PhysicalStrength;
    [Header("获取精神")]
    public int Get_MentalExhaustion;
    [Header("获取物资")]
    public int Get_MaterialConsumption;

    [Header("获得渠道")]
    public string Get;
    [Header("使用渠道")]
    public string Use;
    [Header("视觉表现")]
    public Sprite sprite;

    [Header("标签")]
    public DataTags dataTags;
    public enum DataTags { Physical, Society, Spirit }
    
}