using UnityEngine;
using UnityEngine.InputSystem;

public class OpenMenuInputHandler : MonoBehaviour
{
    [SerializeField] private ActivePage activePage;
    [SerializeField] private PageKeyword mainMenu;
    [SerializeField] private PageKeyword ingredients;
    [SerializeField] private PageKeyword elixirs;
    [SerializeField] private PageKeyword incidents;
    [SerializeField] private PageKeyword map;

    [SerializeField] private GameEvent updateUI;
    [SerializeField] private BoolVariable isBookOpen;
    [SerializeField] private BoolVariable isAlchemyOpen;

    private Inputs inputs;
    private InputAction openMainMenu;
    private InputAction openIngredients;
    private InputAction openElixirs;
    private InputAction openIncidents;
    private InputAction openMap;
    private InputAction openAlchemy;
    private InputAction closeWindow;

    void Start()
    {
        isBookOpen.value = false;
        isAlchemyOpen.value = false;
        activePage.keyword = mainMenu;
        SendUpdateUIEvent();
    }

    private void Awake()
    {
        inputs = new Inputs();
        inputs.Player.Enable();
        inputs.Book.Enable();
        inputs.UINavigation.Disable();
    }

    private void OnEnable()
    {

        openMainMenu = inputs.Book.OpenMainMenu;
        openMainMenu.Enable();
        openMainMenu.performed += OpenMainMenu;

        openIngredients = inputs.Book.OpenIngredients;
        openIngredients.Enable();
        openIngredients.performed += OpenIngredients;

        openElixirs = inputs.Book.OpenElixirs;
        openElixirs.Enable();
        openElixirs.performed += OpenElixirs;

        openIncidents = inputs.Book.OpenIncidents;
        openIncidents.Enable();
        openIncidents.performed += OpenIncidents;

        openMap = inputs.Book.OpenMap;
        openMap.Enable();
        openMap.performed += OpenMap;

        openAlchemy = inputs.Book.OpenAlchemy;
        openAlchemy.Enable();
        openAlchemy.performed += OpenAlchemy;

        closeWindow = inputs.Book.CloseWindow;
        closeWindow.Enable();
        closeWindow.performed += CloseWindow;
    }

    private void OnDisable()
    {
        openMainMenu.Disable();
        openIngredients.Disable();
        openElixirs.Disable();
        openIncidents.Disable();
        openMap.Disable();
        openAlchemy.Disable();
    }

    private void OpenBookPage(PageKeyword keyword)
    {
        activePage.keyword = keyword;
        inputs.Player.Disable();
        inputs.UINavigation.Enable();
        isBookOpen.value = true;
        SendUpdateUIEvent();
    }
    
    private void OpenMainMenu(InputAction.CallbackContext context)
    {
        OpenBookPage(mainMenu);
    }

    private void OpenIngredients(InputAction.CallbackContext context)
    {
        OpenBookPage(ingredients);
    }

    private void OpenElixirs(InputAction.CallbackContext context)
    {
        OpenBookPage(elixirs);
    }

    private void OpenIncidents(InputAction.CallbackContext context)
    {
        OpenBookPage(incidents);
    }

    private void OpenMap(InputAction.CallbackContext context)
    {
        OpenBookPage(map);
    }

    private void OpenAlchemy(InputAction.CallbackContext context)
    {
        inputs.Player.Disable();
        inputs.UINavigation.Enable();
        isAlchemyOpen.value = true;
        SendUpdateUIEvent();
    }

    private void CloseWindow(InputAction.CallbackContext context)
    {
        if (isBookOpen.value)
        {
            isBookOpen.value = false;
            updateUI.Raise();
        }
        else if (isAlchemyOpen.value)
        {
            isAlchemyOpen.value = false;
            updateUI.Raise();
        }
        if (!isBookOpen.value && !isAlchemyOpen.value)
        {
            inputs.Player.Enable();
            inputs.UINavigation.Disable();
        }
    }

    private void SendUpdateUIEvent()
    {
        updateUI.Raise();
    }
}
