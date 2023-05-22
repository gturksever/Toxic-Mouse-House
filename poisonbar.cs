
using UnityEngine;
using UnityEngine.UI;


public class poisonbar : gameover
{
    public Image GreenPoisonBottle;
    float IncreasePoisonBottle=0;
    
    void Start()
    {
        
        InvokeRepeating("PoisonBottleIncrease", 2f, 0.03f);
        // Canvas objesinin alt�nda olan RestartGame objesini buluyoruz
        Transform canvas = GameObject.Find("Canvas").transform; //Canvas objesini yakal�yoruz
        RestartGame = canvas.Find("RestartGame").gameObject;    // Canvas objesinin childi Restargame objesini yakal�yoruz (Obje pasif oldu�u i�in Find komutu ile yapam�yoruz Null hatas� verir.
        
    }

    void PoisonBottleIncrease() 
    {
        
        if (IncreasePoisonBottle != 1) 
        {
            GreenPoisonBottle.fillAmount = IncreasePoisonBottle+0.00023f;
            IncreasePoisonBottle += 0.00023f;
        }
        
    }

    private void Update()
    {
        if (GreenPoisonBottle.fillAmount == 1)
        {
            
           
            RestartGame.SetActive(true); //RestartGame ekran� a��lacak.
            Time.timeScale = 0;       // Restartgame menusu a��l�nca oyunu durduran kod
            GreenPoisonBottle.fillAmount = 0.99f; // 1 de b�rak�nca timescale 0 da kal�yor ve Restartlevel kodu timescale de�erini 1 yap�nca tekrar 0 yap�yor o y�zden bunu eklemek zorunda kald�k.



        }
    }

    
}
