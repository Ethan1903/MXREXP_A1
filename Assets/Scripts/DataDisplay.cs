using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class DataDisplay : MonoBehaviour
{
    public TextMeshProUGUI energy;

    public TextMeshProUGUI protein;

    public TextMeshProUGUI totalFat;
    public TextMeshProUGUI saturatedFat;

    public TextMeshProUGUI cholesterol;
    public TextMeshProUGUI carbohydrates;

    public TextMeshProUGUI dietaryFibre;
    public TextMeshProUGUI sodium;

    public void Init(DataDisplay menuItem)
    {
        energy = menuItem.energy;

        protein= menuItem.protein;
        totalFat = menuItem.totalFat;

        saturatedFat = menuItem.saturatedFat;

        cholesterol = menuItem.cholesterol;
        carbohydrates = menuItem.carbohydrates;

        dietaryFibre= menuItem.dietaryFibre;
        sodium = menuItem.sodium;
    }
}
