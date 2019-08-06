using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlcoPanelController : MonoBehaviour
{
    public Text PanelAlco_Title;
    public Text PanelAlco_Desc;
    public Text PanelAlco_Price;
   
    public void SetPanelContent(string name, string desc, string price)
    {
        PanelAlco_Title.text = name;
        PanelAlco_Desc.text = desc;
        PanelAlco_Price.text = "Price: $"+price;

        PanelVisible();
    }

    public void PanelVisible()
    {
        this.gameObject.SetActive(!(this.gameObject.activeSelf));
    }
}
