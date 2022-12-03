using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Elixir", menuName = "Data/Elixir", order = 0)]
public class ElixirData : ScriptableObject
{
    public string elixirName;
    [TextArea(3, 10)]
    public string description;
    public Sprite thumbnail;
    public Sprite mainImage;
    public IngredientData ingredient1;
    public IngredientData ingredient2;
    public IngredientData ingredient3;
    public bool hasBeenDiscovered;
    public int amountOwned;
    public List<EffectData> effects;

    public List<IngredientData> GetIngredientsOfElixir()
    {
        List<IngredientData> ingredientsOfElixir = new List<IngredientData>();
        ingredientsOfElixir.Add(ingredient1);
        ingredientsOfElixir.Add(ingredient2);
        ingredientsOfElixir.Add(ingredient3);
        return ingredientsOfElixir;
    }
}
