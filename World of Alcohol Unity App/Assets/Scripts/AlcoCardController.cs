using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class AlcoCardController : MonoBehaviour
{
    public Text Alco_Name;
    public Image Alco_Img;
    public Text Alco_Desc;
    public Text Alco_Price;

    public AlcoPanelController panelController;


    public void SetAlcoholCard(string textName, string filePath, string textDesc, string textPrice)
    {
        Alco_Name.text = textName;
        Alco_Img.sprite = Resources.Load<Sprite>(filePath);
        Alco_Desc.text = textDesc;
        Alco_Price.text = textPrice;

    }

    public void OnClickPanel()
    {
        panelController.SetPanelContent(Alco_Name.text, Alco_Desc.text, Alco_Price.text);
    }
}
