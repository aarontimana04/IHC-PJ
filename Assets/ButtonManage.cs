using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManage : MonoBehaviour
{
    public void IrAEscenaAR()
    {

        SceneManager.LoadScene("Menu"); 
        Handheld.Vibrate();
    }

}
