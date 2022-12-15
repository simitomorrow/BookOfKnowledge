using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_AlchemyPopUp : MonoBehaviour
{
    public CanvasGroup ingredients;
    public CanvasGroup cauldron;
    public CanvasGroup thisPopUp;
    public Image mainImage;
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    public TextMeshProUGUI effect1;
    public TextMeshProUGUI effect2;
    public TextMeshProUGUI effect3;

    private ElixirData currentElixir;

    public void Show(ElixirData elixir)
    {
        currentElixir = elixir;

        thisPopUp.alpha = 100f;
        thisPopUp.blocksRaycasts = true;
        thisPopUp.interactable = true;
        ingredients.alpha = 0f;
        ingredients.blocksRaycasts = false;
        ingredients.interactable = false;
        cauldron.alpha = 0f;
        cauldron.blocksRaycasts = false;
        cauldron.interactable = false;


        title.text = elixir.elixirName;
        mainImage.sprite = elixir.GetImageAccordingToDiscovery();
        description.text = elixir.description;
        effect1.text = elixir.GetEffect1().Length > 0 ? "- " + elixir.GetEffect1() : "";
        effect2.text = elixir.GetEffect2().Length > 0 ? "- " + elixir.GetEffect2() : "";
        effect3.text = elixir.GetEffect3().Length > 0 ? "- " + elixir.GetEffect3() : "";
    }

    public void Show()
    {
        Show(currentElixir);
    }

    public void Close()
    {

        thisPopUp.alpha = 0f;
        thisPopUp.blocksRaycasts = false;
        thisPopUp.interactable = false;
        ingredients.alpha = 100f;
        ingredients.blocksRaycasts = true;
        ingredients.interactable = true;
        cauldron.alpha = 100f;
        cauldron.blocksRaycasts = true;
        cauldron.interactable = true;
    }
}
