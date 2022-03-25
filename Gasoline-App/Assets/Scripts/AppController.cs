using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AppController : MonoBehaviour
{
    [SerializeField] GameObject inputField;
    [SerializeField] string inputText;
    [SerializeField] float gasolinePrice;

    public void UpdatePrice(string text)
    {
        float.TryParse(text, out float price);

        gasolinePrice = price;

        if(gasolinePrice != 0)
        {
            Debug.Log("floatParsed:"+gasolinePrice+" |floatNormal:"+price);
        }
        else
        {
            Debug.Log("erro");
            Debug.Log("floatParsed:"+gasolinePrice+"|floatNormal:"+price);
        } 
    }
}
