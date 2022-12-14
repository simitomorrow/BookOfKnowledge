using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_IngredientButton : MonoBehaviour
{
    private IngredientData ingredient;
    public Image thumbnail;
    public Image outOfStockTaint;
    public TextMeshProUGUI ownedAmount;
    public TextMeshProUGUI title;
    public IntVariable selectedIngredient;
    public GameEvent updateUIEvent;
    private int ID;

    public void Initialize(IngredientData ingredient, int id)
    {
        this.ingredient = ingredient;
        thumbnail.sprite = ingredient.GetImageAccordingToDiscovery();
        ownedAmount.text = "" + ingredient.amountOwned;
        title.text = ingredient.ingredientName;
        outOfStockTaint.gameObject.SetActive(ingredient.amountOwned <= 0);
        ID = id;
    }

    public void SelectIngredientInUI()
    {
        selectedIngredient.value = ID;
        updateUIEvent.Raise();
    }

    public void UpdateOwnedAmountNumber()
    {
        ownedAmount.text = "" + ingredient.amountOwned;
        outOfStockTaint.gameObject.SetActive(ingredient.amountOwned <= 0);
    }
}
