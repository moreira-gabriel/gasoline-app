using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputManager : MonoBehaviour
{
    // public delegate void UpdatePriceHandler(float price);
    // public event UpdatePriceHandler PriceUpdated;
    
    // [Header("Strings")]
    string gasolinePriceText;
    string ethanolPriceText;

    [Header("Prices")]
    [SerializeField] float ethanolPrice;
    [SerializeField] float gasolinePrice;


    public void UpdateGasolinePrice(string text)
    {
        gasolinePriceText = text;
        gasolinePrice = PriceParse(text);
        Debug.Log(gasolinePrice);
    }

    public void UpdateEthanolPrice(string text)
    {
        ethanolPriceText = text;
        ethanolPrice = PriceParse(text);
        Debug.Log(ethanolPrice);
    }

    float PriceParse(string text)
    {
        float.TryParse(text, out float price);

        Debug.Log(price);
        return price;
    }
}
