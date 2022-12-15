using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Ingredients : MonoBehaviour
{
    //left side
    public IngredientList ingredients;
    public IntVariable selectedIngredient;
    public Button buttonPrefab;
    public GameObject buttonParent;

    //right side
    public Image mainImage;
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    public TextMeshProUGUI effect1;
    public TextMeshProUGUI effect2;
    public TextMeshProUGUI effect3;

    private List<Button> buttons = new List<Button>();

    private void Start()
    {
        CultivateButtons();
        SelectIngredient();
    }

    private void CultivateButtons()
    {
        int id = 0;
        foreach (IngredientData ingredient in ingredients.list)
        {
            Button button = Instantiate(buttonPrefab, buttonParent.transform);
            UI_IngredientButton elixirButton = button.GetComponentInChildren<UI_IngredientButton>();
            elixirButton.Initialize(ingredient, id);
            buttons.Add(button);
            id++;
        }
    }

    public void SelectIngredient()
    {
        if (selectedIngredient.value >= ingredients.list.Count || selectedIngredient.value < 0)
        {
            Debug.LogError("Elixir selection out of range. Elixir count: " + ingredients.list.Count + "  - selected elixir number: " + (selectedIngredient.value + 1));
            selectedIngredient.value = 0;
        }
        int index = selectedIngredient.value;
        buttons[index].Select();
        description.text = ingredients.list[index].description;
        IngredientData ingredient = ingredients.list[index];
        effect1.text = ingredient.GetEffect1AccordingToDiscovery().effectName;
        effect2.text = ingredient.GetEffect2AccordingToDiscovery().effectName;
        effect3.text = ingredient.GetEffect3AccordingToDiscovery().effectName;
        title.text = ingredients.list[index].ingredientName;
        mainImage.sprite = ingredients.list[index].GetImageAccordingToDiscovery();
    }
}
