using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadData : MonoBehaviour
{
    public Text TitleText;

    public AlcoCardController AlcoholCard;
    //public GameObject AlcoholCard_Desc;

    string Username;
    int AmountOfFav;
    public List<AlcoholClass> alcohols;

    // Start is called before the first frame update
    void Start()
    {
        LoadFromPlayerPrefs();
        SetComponents();
    }


    void LoadFromPlayerPrefs()
    {
        Username = PlayerPrefs.GetString("username", "user");
        AmountOfFav = PlayerPrefs.GetInt("alcohols.Length", 0);
        for (int i = 0; i < AmountOfFav; i++)
        {
            alcohols.Add(new AlcoholClass(PlayerPrefs.GetString(i + "")));
        }
    }

    void SetComponents()
    {
        TitleText.GetComponent<Text>().text = $"Hello {Username}!";

        for (int i = 0; i < alcohols.Count; i++)
        {
            AlcoCardController copy = Instantiate(AlcoholCard, AlcoholCard.transform.parent);
            copy.gameObject.SetActive(true);
            copy.SetAlcoholCard(alcohols[i].Name, ""+alcohols[i].Id, alcohols[i].Desc, alcohols[i].Price);
        }
        
    }
}
