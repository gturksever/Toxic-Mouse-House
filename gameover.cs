
using UnityEngine;

public class gameover : MonoBehaviour
{
    protected GameObject RestartGame;
    


    void Start()
    {
        
        // Canvas objesinin alt�nda olan RestartGame objesini buluyoruz
        Transform canvas = GameObject.Find("Canvas").transform; //Canvas objesini yakal�yoruz
        RestartGame = canvas.Find("RestartGame").gameObject;    // Canvas objesinin childi Restargame objesini yakal�yoruz (Obje pasif oldu�u i�in Find komutu ile yapam�yoruz Null hatas� verir.)
        
    }

    private void LateUpdate()
    {
        if ((Input.GetKeyDown(KeyCode.JoystickButton4) || Input.GetKeyDown(KeyCode.Escape)) && Time.timeScale!=0) // buton ile menu a� kapa ekran�
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
        if (col.gameObject.CompareTag("car")) // bu scriptin tan�ml� oldu�u obje ile tagi "car" olan bir nesne �arp���rsa �al��ma ko�ulu.
        {
            
            RestartGame.SetActive(true);      // Canvas alt�nda bulunan RestartGame ekran�n� aktif eden kod
            Time.timeScale = 0;            // Restartgame menusu a��l�nca oyunu durduran kod
            


        }
    }

    
    
}


