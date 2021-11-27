using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MenuItem", menuName = "Custom/MenuItem")]
[System.Serializable]
public class MenuItem : ScriptableObject
{
    public string menuItemName;

    public int energy;

    public float protein;

    public float fatTotal;
    public float fatSaturated;

    public float carbohydrateTotal;
    public float carbohydrateSugars;

    public float dietaryFibre;
    public float sodium;
}
