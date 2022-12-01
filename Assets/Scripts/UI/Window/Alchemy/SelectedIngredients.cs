using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SelectedIngredient", menuName = "UI-Information/SelectedIngredient", order = 0)]
public class SelectedIngredients : ScriptableObject
{
    public IngredientData selectedIngredient1;
    public IngredientData selectedIngredient2;
    public IngredientData selectedIngredient3;
    public GameEvent updateAlchemyUIEvent;

    public void Reset()
    {
        selectedIngredient1 = null;
        selectedIngredient2 = null;
        selectedIngredient3 = null;
    }

    public bool addIngredient(IngredientData ingredient)
    {
        if (selectedIngredient1 == null)
        {
            selectedIngredient1 = ingredient;
            updateAlchemyUIEvent.Raise();
            return true;
        }
        if (selectedIngredient2 == null)
        {
            selectedIngredient2 = ingredient;
            updateAlchemyUIEvent.Raise();
            return true;
        }
        if (selectedIngredient3 == null)
        {
            selectedIngredient3 = ingredient;
            updateAlchemyUIEvent.Raise();
            return true;
        }
        updateAlchemyUIEvent.Raise();
        return false;
    }
    
    public void removeIngredient(IngredientData ingredient)
    {
        if (selectedIngredient1 == ingredient)
        {
            selectedIngredient1 = null;
        }
        if (selectedIngredient2 == ingredient)
        {
            selectedIngredient2 = null;
        }
        if (selectedIngredient3 == ingredient)
        {
            selectedIngredient3 = null;
        }
        updateAlchemyUIEvent.Raise();
    }

    public List<IngredientData> GetIngredients()
    {
        List<IngredientData> res = new List<IngredientData>();
        res.Add(selectedIngredient1);
        res.Add(selectedIngredient2);
        res.Add(selectedIngredient3);
        return res;
    }
}
