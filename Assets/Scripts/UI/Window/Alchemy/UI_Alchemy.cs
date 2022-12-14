using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Alchemy: MonoBehaviour
{
    [SerializeField] private ElixirList allElixirs;
    [SerializeField] private ElixirData garbage;
    [SerializeField] private IngredientList ingredients;
    [SerializeField] private Button ingredientButtonPrefab;
    [SerializeField] private GameObject ingredientButtonParent;

    [SerializeField] private SelectedIngredients selectedIngredients;
    [SerializeField] private Button alchemySlotButtonPrefab;
    [SerializeField] private GameObject alchemySlot1Parent;
    [SerializeField] private GameObject alchemySlot2Parent;
    [SerializeField] private GameObject alchemySlot3Parent;
    [SerializeField] private Button brewButton;

    [SerializeField] private Button elixirResultPrefab;
    [SerializeField] private GameObject elixirResultParent;

    [SerializeField] private GameEvent updateAmountOwnedUI;

    private void Start()
    {
        InitializeInventoryUI();
    }

    private void InitializeInventoryUI()
    {
        foreach (IngredientData ingredient in ingredients.list)
        {
            Button iButtonPrefab = Instantiate(ingredientButtonPrefab, ingredientButtonParent.transform);
            UI_AlchemyIngredient ingredientButton = iButtonPrefab.GetComponentInChildren<UI_AlchemyIngredient>();
            ingredientButton.Initialize(ingredient);
            selectedIngredients.Reset();
            brewButton.interactable = false;
        }
    }

    public void UpdateAmountOwnedUI()
    {
        updateAmountOwnedUI.Raise();
    }

    //I dont know how to make this prettier
    public void UpdateAlchemyUI()
    {
        List<IngredientData> ingredients = selectedIngredients.GetIngredients();
        ManageAlchemySlot(ingredients[0], alchemySlot1Parent);
        ManageAlchemySlot(ingredients[1], alchemySlot2Parent);
        ManageAlchemySlot(ingredients[2], alchemySlot3Parent);

        brewButton.interactable = CanBrewElixir(ingredients);

        void ManageAlchemySlot(IngredientData ingredient, GameObject slotParent)
        {
            if (ingredient == null)
            {
                foreach (Transform child in slotParent.transform)
                {
                    Destroy(child.gameObject);
                }
            }
            else if (slotParent.transform.childCount == 0)
            {
                Button button = Instantiate(alchemySlotButtonPrefab, slotParent.transform);
                UI_AlchemySlot slotButton = button.GetComponentInChildren<UI_AlchemySlot>();
                slotButton.Initialize(ingredient);
                return;
            }
        }

        bool CanBrewElixir(List<IngredientData> ingredients)
        {
            foreach (IngredientData ingredient in ingredients)
            {
                if (ingredient == null || ingredient.amountOwned <= 0)
                {
                    return false;
                }
            }
            return true;
        }
    }


    //1. look up correct elixir
    //2. create elixir and add count
    //3. reveal newly found effects
    //4. remove used ingredients
    //5. update UI
    public void BrewElixir()
    {
        List<IngredientData> ingredients = selectedIngredients.GetIngredients();
        ElixirData elixirBrewed = GetElixierFromIngredients(ingredients);
        elixirBrewed.amountOwned++;
        elixirBrewed.hasBeenDiscovered = true;

        foreach (IngredientData ingredient in ingredients)
        {
            if (!ingredient.effect1Discovered)
            {
                ingredient.effect1Discovered = elixirBrewed.effects.Contains(ingredient.GetEffect1());
            }
            if (!ingredient.effect2Discovered)
            {
                ingredient.effect2Discovered = elixirBrewed.effects.Contains(ingredient.GetEffect2());
            }
            if (!ingredient.effect3Discovered)
            {
                ingredient.effect3Discovered = elixirBrewed.effects.Contains(ingredient.GetEffect3());
            }

            ingredient.amountOwned--;
        }
        UpdateElixirSlotUI(elixirBrewed);
        UpdateAmountOwnedUI();
    }

    private ElixirData GetElixierFromIngredients(List<IngredientData> ingredients)
    {
        foreach (ElixirData elixir in allElixirs.list)
        {
            int ingredientCounter = 0;
            foreach (IngredientData ingredient in ingredients)
            {
                if (elixir.GetIngredientsOfElixir().Contains(ingredient))
                {
                    ingredientCounter++;
                }
            }
            if (ingredientCounter >= 3)
            {
                return elixir;
            }
        }
        return garbage;
    }

    private void UpdateElixirSlotUI(ElixirData elixirBrewed)
    {
        Button button = Instantiate(elixirResultPrefab, elixirResultParent.transform);
        UI_AlchemyElixir slotButton = button.GetComponentInChildren<UI_AlchemyElixir>();
        slotButton.ShowResult(elixirBrewed);
    }

    private void DEBUG_DelevoperCheck()
    {
        /*
         * Make sure our own rules apply
         * (two different ingredients must have the same effect for a useful elixir)
         */
    }
}
