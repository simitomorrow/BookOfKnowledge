using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ingredient", menuName = "Data/Ingredient", order = 0)]
public class IngredientData : ScriptableObject
{
    public string ingredientName;
    [TextArea(3, 10)]
    public string description;
    [SerializeField]
    private Sprite image;
    [SerializeField]
    private Sprite undiscoveredImage;
    public bool hasBeenDiscovered;

    [SerializeField]
    private EffectData effect1;
    public bool effect1Discovered;
    [SerializeField]
    private EffectData effect2;
    public bool effect2Discovered;
    [SerializeField]
    private EffectData effect3;
    public bool effect3Discovered;

    public EffectData undiscovered;

    public int amountOwned;

    [SerializeField]
    private static string undiscoveredString = "???";

    public string GetNameAccordingToDiscovery()
    {
        if (hasBeenDiscovered)
        {
            return ingredientName;
        }
        else
        {
            return undiscoveredString;
        }
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

    public EffectData GetEffect1()
    {
        return effect1;
    }

    public EffectData GetEffect2()
    {
        return effect2;
    }

    public EffectData GetEffect3()
    {
        return effect3;
    }

    public EffectData GetEffect1AccordingToDiscovery()
    {
        if (effect1Discovered)
        {
            return effect1;
        } else
        {
           return undiscovered;
        }
    }

    public EffectData GetEffect2AccordingToDiscovery()
    {
        if (effect2Discovered)
        {
            return effect2;
        }
        else
        {
            return undiscovered;
        }
    }

    public EffectData GetEffect3AccordingToDiscovery()
    {
        if (effect3Discovered)
        {
            return effect3;
        }
        else
        {
            return undiscovered;
        }
    }
}
