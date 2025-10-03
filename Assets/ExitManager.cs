using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitManager : MonoBehaviour
{
    public void IrAMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitProgram()
    {
        Debug.Log("Saliendo de la aplicación");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); 
#endif
    }
}
