using UnityEngine.SceneManagement;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }


    public GameState estadoAtual;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    void Start()
    {
        TrocarEstado(GameState.Iniciando);
        CarregarSplash();
    }


    public enum GameState
    {
        Iniciando,
        MenuPrincipal,
        Gameplay,
        SampleScene
    }


    public void TrocarEstado(GameState novoEstado)
    {
        estadoAtual = novoEstado;
        Debug.Log("Estado mudou para: " + estadoAtual);
    }


    public void CarregarSplash()
    {
        SceneManager.LoadScene(1); // Splash
    }


    public void IrParaMenuPrincipal()
    {
        TrocarEstado(GameState.MenuPrincipal);
        SceneManager.LoadScene(2); // MenuPrincipal
    }


    public void IniciarJogo()
    {
        TrocarEstado(GameState.Gameplay);
        SceneManager.LoadScene(3); // SampleScene
    }
}