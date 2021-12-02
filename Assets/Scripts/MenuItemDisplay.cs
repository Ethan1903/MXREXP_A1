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

    public GameObject addedMenu;

    public void Init(MenuItem menuItem)
    {
        foodName.text = menuItem.menuItemName.ToString();
        energy.text = menuItem.energy.ToString("F1");
         
        protein.text = menuItem.protein.ToString("F1");
        totalFat.text = menuItem.totalFat.ToString("F1");

        saturatedFat.text = menuItem.saturatedFat.ToString("F1");

        cholesterol.text = menuItem.cholesterol.ToString("F1");
        carbohydrates.text = menuItem.carbohydrates.ToString("F1");

        dietaryFibre.text = menuItem.dietaryFibre.ToString("F1");
        sodium.text = menuItem.sodium.ToString("F1");
    }
}
