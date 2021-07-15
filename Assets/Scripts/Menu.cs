using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public string nomeCena;
    public void newGame()
    {
        SceneManager.LoadScene(nomeCena);
    }
    public void quitGame()
    {
        //jogo compilado
        //Application.Quit();
        //no editor do unity
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
