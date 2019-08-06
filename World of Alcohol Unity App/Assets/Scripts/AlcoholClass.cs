using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlcoholClass : MonoBehaviour
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Desc { get; set; }
    public string Price { get; set; }
    
    public AlcoholClass(string data)
    {
        string[] elements = data.Split('*');
        Id = int.Parse(elements[0]);
        Name = elements[1];
        Desc = elements[2];
        Price = elements[3];
    }
}
