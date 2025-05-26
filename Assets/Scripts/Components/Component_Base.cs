using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Component_Base : MonoBehaviour
{

    public Base_Data base_Data;

    void Awake()
    {
        transform.GetComponent<Image>().sprite = base_Data.sprite;
        transform.GetComponentInChildren<TextMeshProUGUI>().text = base_Data.Name;
    }

}
