using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void IrAEscenaAR()
    {
        SceneManager.LoadScene("PutFurnites"); // nombre exacto de tu escena AR
    }

    public void IrADocumentacion()
    {
        Debug.Log("Abrir tutorial");
        SceneManager.LoadScene("Tutorial");
    }

    public void Salir()
    {
        Debug.Log("Salir del juego...");
        SceneManager.LoadScene("ExitMessage");
    }
}
