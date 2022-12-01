using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadUIScene : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("UIScene", LoadSceneMode.Additive);
    }
}
