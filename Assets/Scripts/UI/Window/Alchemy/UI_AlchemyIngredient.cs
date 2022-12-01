using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_AlchemyIngredient : MonoBehaviour
{
    public Image thumbnail;
    public Image selectedBoarder;
    public Image outOfStockTaint;
    public TextMeshProUGUI title;
    public TextMeshProUGUI ownedAmount;
    public SelectedIngredients selectedIngredients;
    private IngredientData ingredient;
    private bool isSelected;

    public void Initialize(IngredientData iData)
    {
        thumbnail.sprite = iData.thumbnail;
        selectedBoarder.gameObject.SetActive(false);
        outOfStockTaint.gameObject.SetActive(iData.amountOwned <= 0);
        title.text = iData.ingredientName;
        ownedAmount.text = "" + iData.amountOwned;
        ingredient = iData;
        isSelected = false;
    }

    public void UpdateOwnedAmount()
    {
        ownedAmount.text = "" + ingredient.amountOwned;
        outOfStockTaint.gameObject.SetActive(ingredient.amountOwned <= 0);
    }

    public void ToggleSelection()
    {
        if (isSelected)
        {
            selectedBoarder.gameObject.SetActive(false);
            selectedIngredients.removeIngredient(ingredient);
            isSelected = !isSelected;
        } else
        {
            bool itWorked = selectedIngredients.addIngredient(ingredient);
            if (itWorked)
            {
                isSelected = !isSelected;
                selectedBoarder.gameObject.SetActive(true);
            }
        }
    }

    /*  Why is this needed?
     *  If the SlotButton gets pressed to remove the ingredient, it shouldn't be highlighted in the inventory anymore.
     *  Not sure if there is a prettier way...
     */ 
    public void CheckIfStillSelected()
    {
        if (isSelected)
        {
            if (!selectedIngredients.GetIngredients().Contains(ingredient))
            {
                selectedBoarder.gameObject.SetActive(false);
                isSelected = !isSelected;
            }
        }
    }
}
