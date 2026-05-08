using UnityEngine;


public class MenuUI : MonoBehaviour
{
    public void Entrar()
    {
        Debug.Log("Andamento!");
        GameManager.Instance.IniciarJogo();
    }


    public void Sair()
    {
        Application.Quit();
    }
}
