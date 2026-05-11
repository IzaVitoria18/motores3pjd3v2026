using UnityEngine;


public class SplashScript : MonoBehaviour
{
    void Start()
    {
        Invoke("GoToMenu", 2f);
    }


    void GoToMenu()
    {
        GameManager.Instance.IrParaMenuPrincipal();
    }
}





