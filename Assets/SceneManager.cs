using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void SceneChange()
    {

        SceneManager.LoadScene("Animation");
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
    
    public void ResetAnimationScene()
    {
        SceneManager.LoadScene("Animation");
    }
}