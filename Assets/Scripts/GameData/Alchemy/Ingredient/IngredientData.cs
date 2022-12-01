using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ingredient", menuName = "Data/Ingredient", order = 0)]
public class IngredientData : ScriptableObject
{
    public string ingredientName;
    [TextArea(3, 10)]
    public string description;
    public Sprite thumbnail;
    public Sprite mainImage;
    public EffectData effect1;
    public bool effect1Discovered;
    public EffectData effect2;
    public bool effect2Discovered;
    public EffectData effect3;
    public bool effect3Discovered;
    public int amountOwned;
}
