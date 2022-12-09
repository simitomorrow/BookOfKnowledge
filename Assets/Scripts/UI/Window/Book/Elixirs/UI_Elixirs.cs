using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Elixirs : MonoBehaviour
{
    //left side
    public ElixirList elixirs;
    public IntVariable selectedElixir;
    public Button buttonPrefab;
    public GameObject buttonParent;

    //right side
    public Image mainImage;
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    public TextMeshProUGUI effect1;
    public TextMeshProUGUI effect2;
    public TextMeshProUGUI effect3;
    public Image ingredient1;
    public Image ingredient2;
    public Image ingredient3;

    public Image unknownIngredient;

    private List<Button> buttons = new List<Button>();

    private void Start()
    {
        CultivateButtons();
        SelectElixir();
    }

    private void CultivateButtons()
    {
        int id = 0;
        foreach (ElixirData elixir in elixirs.list)
        {
            if (elixir.hasBeenDiscovered)
            {
                Button button = Instantiate(buttonPrefab, buttonParent.transform);
                UI_ElixirButton elixirButton = button.GetComponentInChildren<UI_ElixirButton>();
                elixirButton.Initialize(elixir, id);
                buttons.Add(button);
                id++;
            }
        }
    }

    public void SelectElixir()
    {
        if (selectedElixir.value >= elixirs.list.Count || selectedElixir.value < 0)
        {
            Debug.LogError("Elixir selection out of range. Elixir count: " + elixirs.list.Count + "  - selected elixir number: " + (selectedElixir.value + 1));
            selectedElixir.value = 0;
        }
        int index = selectedElixir.value;
        buttons[index].Select();
        description.text = elixirs.list[index].description;
        List<EffectData> effects = elixirs.list[index].effects;
        effect1.text = effects[0] ? effects[0].description: "";
        effect2.text = effects[1] ? effects[1].description: "";
        effect3.text = effects[2] ? effects[2].description: "";
        ingredient1.sprite = elixirs.list[index].ingredient1.GetImageAccordingToDiscovery();
        ingredient2.sprite = elixirs.list[index].ingredient2.GetImageAccordingToDiscovery();
        ingredient3.sprite = elixirs.list[index].ingredient3.GetImageAccordingToDiscovery();
        title.text = elixirs.list[index].elixirName;
        mainImage.sprite = elixirs.list[index].GetImageAccordingToDiscovery();
    }
}
