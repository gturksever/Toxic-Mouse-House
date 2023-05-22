
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
        // chapter 2 kodlar� gelecek
    }

    public void MainMenuToLevelThree()
    {
        // chapter 3 kodlar� gelecek
    }

    public void QuitGame() 
    {
        Application.Quit();
        Debug.Log("Oyun kapat�ld�!");
    }

}
