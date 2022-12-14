using UnityEngine;
using UnityEngine.InputSystem;

public class UI_OpenWindowInputHandler : MonoBehaviour
{
    [SerializeField] private ActivePage activePage;
    [SerializeField] private PageKeyword mainMenu;
    [SerializeField] private PageKeyword ingredients;
    [SerializeField] private PageKeyword elixirs;
    [SerializeField] private PageKeyword incidents;

    [SerializeField] private GameEvent windowVisibilityEvent;
    [SerializeField] private BoolVariable isBookOpen;
    [SerializeField] private BoolVariable isAlchemyOpen;

    //The 3D movement of the StarterAssetsLibrary uses it's own inputsystem which I have to disable myself
    //TODO if only there is a prettier way...
    [SerializeField] private BoolVariable canPlayerMove;

    private Inputs inputs;
    private InputAction openMainMenu;
    private InputAction openIngredients;
    private InputAction openElixirs;
    private InputAction openIncidents;
    private InputAction openAlchemy;
    private InputAction closeWindow;

    private InputAction debug;

    void Start()
    {
        isBookOpen.value = false;
        isAlchemyOpen.value = false;
        activePage.keyword = mainMenu;
        EnablePlayerMovement();
        inputs.Book.Enable();
        SendWindowVisibilityEvent();
    }

    private void Awake()
    {
        inputs = new Inputs();
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

        openAlchemy = inputs.Book.OpenAlchemy;
        openAlchemy.Enable();
        openAlchemy.performed += OpenAlchemy;

        closeWindow = inputs.Book.CloseWindow;
        closeWindow.Enable();
        closeWindow.performed += CloseWindow;

        debug = inputs.UINavigation.Debug;
        debug.Enable();
        debug.performed += Test;
    }

    private void OnDisable()
    {
        openMainMenu.Disable();
        openIngredients.Disable();
        openElixirs.Disable();
        openIncidents.Disable();
        openAlchemy.Disable();
    }

    private void OpenBookPage(PageKeyword keyword)
    {
        DisablePlayerMovement();
        isBookOpen.value = true;
        activePage.keyword = keyword;
        SendWindowVisibilityEvent();
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

    private void OpenAlchemy(InputAction.CallbackContext context)
    {
        DisablePlayerMovement();
        isAlchemyOpen.value = true;
        SendWindowVisibilityEvent();
    }

    private void CloseWindow(InputAction.CallbackContext context)
    {
        CloseWindow();
    }

    public void CloseWindow()
    {
        if (isBookOpen.value)
        {
            isBookOpen.value = false;
            windowVisibilityEvent.Raise();
        }
        else if (isAlchemyOpen.value)
        {
            isAlchemyOpen.value = false;
            windowVisibilityEvent.Raise();
        }
        if (!isBookOpen.value && !isAlchemyOpen.value)
        {
            EnablePlayerMovement();
        }
    }

    private void SendWindowVisibilityEvent()
    {
        windowVisibilityEvent.Raise();
    }

    private void Test(InputAction.CallbackContext context)
    {
        Debug.Log("i can press things :)");
    }

    private void EnablePlayerMovement()
    {
        inputs.Player.Enable();
        canPlayerMove.value = true;
        inputs.UINavigation.Disable();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void DisablePlayerMovement()
    {
        inputs.Player.Disable();
        canPlayerMove.value = false;
        inputs.UINavigation.Enable();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
}
