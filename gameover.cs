
using UnityEngine;

public class gameover : MonoBehaviour
{
    protected GameObject RestartGame;
    


    void Start()
    {
        
        // Canvas objesinin altýnda olan RestartGame objesini buluyoruz
        Transform canvas = GameObject.Find("Canvas").transform; //Canvas objesini yakalýyoruz
        RestartGame = canvas.Find("RestartGame").gameObject;    // Canvas objesinin childi Restargame objesini yakalýyoruz (Obje pasif olduðu için Find komutu ile yapamýyoruz Null hatasý verir.)
        
    }

    private void LateUpdate()
    {
        if ((Input.GetKeyDown(KeyCode.JoystickButton4) || Input.GetKeyDown(KeyCode.Escape)) && Time.timeScale!=0) // buton ile menu aç kapa ekraný
        {
            if (RestartGame.activeSelf)
            {
                RestartGame.SetActive(false);
                Time.timeScale = 1;
            }

            else
            {
                RestartGame.SetActive(true);
                Time.timeScale = 0.4f;
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("car")) // bu scriptin tanýmlý olduðu obje ile tagi "car" olan bir nesne çarpýþýrsa çalýþma koþulu.
        {
            
            RestartGame.SetActive(true);      // Canvas altýnda bulunan RestartGame ekranýný aktif eden kod
            Time.timeScale = 0;            // Restartgame menusu açýlýnca oyunu durduran kod
            


        }
    }

    
    
}


