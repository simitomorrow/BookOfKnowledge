using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UI_AlchemySlot : MonoBehaviour
{
    public Image thumbnail;
    public Image outOfStockTaint;
    public TextMeshProUGUI ownedAmount;
    public SelectedIngredients selectedIngredients;
    private IngredientData ingredient;

    public GameEvent toggleInventoryButtonEvent;

    public void Initialize(IngredientData iData)
    {
        thumbnail.sprite = iData.image;
        outOfStockTaint.gameObject.SetActive(iData.amountOwned <= 0);
        ownedAmount.text = "" + iData.amountOwned;
        ingredient = iData;
    }

    public void UpdateOwnedAmount()
    {
        ownedAmount.text = "" + ingredient.amountOwned;
        outOfStockTaint.gameObject.SetActive(ingredient.amountOwned <= 0);
    }

    public void RemoveYourself()
    {
        selectedIngredients.removeIngredient(ingredient);
        toggleInventoryButtonEvent.Raise();
        GameObject.Destroy(this.gameObject);
    }
}
