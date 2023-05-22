
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;

        this.gameObject.SetActive(false);
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
}
