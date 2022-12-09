using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Elixir", menuName = "Data/Elixir", order = 0)]
public class ElixirData : ScriptableObject
{
    public string elixirName;
    [TextArea(3, 10)]
    public string description;
    public Sprite image;
    public Sprite undiscoveredImage;
    public IngredientData ingredient1;
    public IngredientData ingredient2;
    public IngredientData ingredient3;
    public bool hasBeenDiscovered;
    public int amountOwned;
    public List<EffectData> effects;

    private static string emptyText = "";

    public List<IngredientData> GetIngredientsOfElixir()
    {
        List<IngredientData> ingredientsOfElixir = new List<IngredientData>();
        ingredientsOfElixir.Add(ingredient1);
        ingredientsOfElixir.Add(ingredient2);
        ingredientsOfElixir.Add(ingredient3);
        return ingredientsOfElixir;
    }
    public Sprite GetImageAccordingToDiscovery()
    {
        if (hasBeenDiscovered)
        {
            return image;
        }
        else
        {
            return undiscoveredImage;
        }
    }

    public string GetEffect1()
    {
        EffectData effect = effects[0];
        if (effect != null)
        {
            return effect.effectName;
        }
        return emptyText;
    }

    public string GetEffect2()
    {
        EffectData effect = effects[1];
        if (effect != null)
        {
            return effect.effectName;
        }
        return emptyText;
    }

    public string GetEffect3()
    {
        EffectData effect = effects[2];
        if (effect != null)
        {
            return effect.effectName;
        }
        return emptyText;
    }
}
