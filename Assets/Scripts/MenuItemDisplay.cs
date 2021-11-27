using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class MenuItemDisplay : MonoBehaviour
{
    public TextMeshProUGUI energy;

    public TextMeshProUGUI protein;

    public TextMeshProUGUI fatTotal;
    public TextMeshProUGUI fatSaturated;

    public TextMeshProUGUI carbohydrateTotal;
    public TextMeshProUGUI carbohydrateSugars;

    public TextMeshProUGUI dietaryFibre;
    public TextMeshProUGUI sodium;

    public void Init(MenuItem menuItem)
    {
        energy.text = "Energy: " + menuItem.energy;
         
        protein.text = "Protein: " + menuItem.protein;
        fatTotal.text = "Fat Total: " + menuItem.fatTotal;
        return;
        fatSaturated.text = "FatSaturated: " + menuItem.fatSaturated;

        carbohydrateTotal.text = "carbohydratearbohydrate Total: " + menuItem.carbohydrateTotal;
        carbohydrateSugars.text = "Carbohydrate Sugars: " + menuItem.carbohydrateSugars;

        dietaryFibre.text = "Dietary Fibre: " + menuItem.dietaryFibre;
        sodium.text = "Sodium: " + menuItem.sodium;
    }
}
