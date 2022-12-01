using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ingredient List", menuName = "Lists/Ingredient List", order = 0)]
public class IngredientList : ScriptableObject
{
    public List<IngredientData> list = new List<IngredientData>();
}
