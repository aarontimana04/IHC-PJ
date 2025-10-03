using UnityEngine;
using UnityEngine.SceneManagement;

public class CancelButton : MonoBehaviour
{
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
