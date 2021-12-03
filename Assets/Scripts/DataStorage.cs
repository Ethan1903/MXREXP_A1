using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStorage : MonoBehaviour
{
    private static DataStorage dataInstance;
    public static DataStorage dataStorageInstance { get { return dataInstance; } }

    public List<MenuItem> itemsAdded = new List<MenuItem>();
    public GameObject addedMenu;
    public DataDisplay displayInfo;

    private float totalEnergy = 0;
    private float totalProtein = 0;
    private float totalFat = 0;
    private float totalSaturatedFat = 0;
    private float totalCholesterol = 0;
    private float totalCarbohydrates = 0;
    private float totalDietaryFibre = 0;
    private float totalSodium = 0;

    double timer = 0;

    private void Start()
    {
        if (dataInstance != null && dataInstance != this)
        {
            Destroy(this.gameObject);
        }
        else
            dataInstance = this;
    }

    public void AddItemToData(MenuItem item)
    {
        itemsAdded.Add(item);

        //if (!addedMenu.activeSelf)
        //{
        //    addedMenu.SetActive(true);
        //    timer = 2f;
        //}

        //if (timer > 0)
        //    timer -= Time.deltaTime;
        //else
        //{
        //    timer = 0;
        //    if (addedMenu.activeSelf)
        //        addedMenu.SetActive(false);
        //}
    }

    public void UpdateIntakeDisplay()
    {
        totalEnergy = 0;
        totalProtein = 0;
        totalFat = 0;
        totalSaturatedFat = 0;
        totalCholesterol = 0;
        totalCarbohydrates = 0;
        totalDietaryFibre = 0;
        totalSodium = 0;

        foreach (MenuItem item in itemsAdded)
        {
            if (item)
            {
                totalSodium += item.sodium;
                totalProtein += item.protein;
                totalFat += item.totalFat;
                totalSaturatedFat += item.saturatedFat;
                totalCholesterol += item.cholesterol;
                totalCarbohydrates += item.carbohydrates;
                totalDietaryFibre += item.dietaryFibre;

                displayInfo.sodium.text = totalSodium.ToString("F1");
                displayInfo.protein.text = totalProtein.ToString("F1");
                displayInfo.totalFat.text = totalFat.ToString("F1");
                displayInfo.saturatedFat.text = totalSaturatedFat.ToString("F1");
                displayInfo.cholesterol.text = totalCholesterol.ToString("F1");
                displayInfo.carbohydrates.text = totalCarbohydrates.ToString("F1");
                displayInfo.dietaryFibre.text = totalDietaryFibre.ToString("F1");

            }
        }

        //displayInfo.Init(displayInfo);
    }
}
