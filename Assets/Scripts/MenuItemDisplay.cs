using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class MenuItemDisplay : MonoBehaviour
{
    public TextMeshProUGUI foodName;

    public TextMeshProUGUI energy;

    public TextMeshProUGUI protein;

    public TextMeshProUGUI totalFat;
    public TextMeshProUGUI saturatedFat;

    public TextMeshProUGUI cholesterol;
    public TextMeshProUGUI carbohydrates;

    public TextMeshProUGUI dietaryFibre;
    public TextMeshProUGUI sodium;

    public void Init(MenuItem menuItem)
    {
        foodName.text = menuItem.menuItemName.ToString();
        energy.text = menuItem.energy.ToString();
         
        protein.text = menuItem.protein.ToString();
        totalFat.text = menuItem.totalFat.ToString();

        saturatedFat.text = menuItem.saturatedFat.ToString();

        cholesterol.text = menuItem.cholesterol.ToString();
        carbohydrates.text = menuItem.carbohydrates.ToString();

        dietaryFibre.text = menuItem.dietaryFibre.ToString();
        sodium.text = menuItem.sodium.ToString();
    }
}
