
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public void MainMenuToLevelOne()
    {
        SceneManager.LoadScene("level1");
    }

    public void MainMenuToLevelTwo()
    {
        // chapter 2 kodlarý gelecek
    }

    public void MainMenuToLevelThree()
    {
        // chapter 3 kodlarý gelecek
    }

    public void QuitGame() 
    {
        Application.Quit();
        Debug.Log("Oyun kapatýldý!");
    }

}
