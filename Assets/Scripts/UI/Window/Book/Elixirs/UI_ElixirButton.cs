using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_ElixirButton : MonoBehaviour
{
    private ElixirData elixir;
    public Image thumbnail;
    public Image outOfStockTaint;
    public TextMeshProUGUI ownedAmount;
    public TextMeshProUGUI title;
    public IntVariable selectedElixir;
    public GameEvent updateUIEvent;
    private int ID;

    public void Initialize(ElixirData elixir, int id)
    {
        this.elixir = elixir;
        thumbnail.sprite = elixir.GetImageAccordingToDiscovery();
        ownedAmount.text = "" + elixir.amountOwned;
        outOfStockTaint.gameObject.SetActive(elixir.amountOwned <= 0);
        title.text = elixir.elixirName;
        ID = id;
    }

    public void SelectElixirInUI()
    {
        selectedElixir.value = ID;
        updateUIEvent.Raise();
    }

    public void UpdateOwnedAmountNumber()
    {
        ownedAmount.text = "" + elixir.amountOwned;
        outOfStockTaint.gameObject.SetActive(elixir.amountOwned <= 0);
    }
}
