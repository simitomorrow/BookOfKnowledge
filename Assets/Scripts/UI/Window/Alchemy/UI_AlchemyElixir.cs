using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UI_AlchemyElixir : MonoBehaviour
{
    public Image thumbnail;
    public Image outOfStockTaint;
    public TextMeshProUGUI ownedAmount;
    private ElixirData elixir;

    public void ShowResult(ElixirData eData)
    {
        thumbnail.sprite = eData.thumbnail;
        outOfStockTaint.gameObject.SetActive(eData.amountOwned <= 0);
        ownedAmount.text = "" + eData.amountOwned;
        elixir = eData;
    }

    public void UpdateOwnedAmount()
    {
        ownedAmount.text = "" + elixir.amountOwned;
        outOfStockTaint.gameObject.SetActive(elixir.amountOwned <= 0);
    }

    public void RemoveYourself()
    {

        foreach (Transform child in transform.parent.transform)
        {
            Destroy(child.gameObject);
        }
    }
}
