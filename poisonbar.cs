
using UnityEngine;
using UnityEngine.UI;


public class poisonbar : gameover
{
    public Image GreenPoisonBottle;
    float IncreasePoisonBottle=0;
    
    void Start()
    {
        
        InvokeRepeating("PoisonBottleIncrease", 2f, 0.03f);
        // Canvas objesinin altýnda olan RestartGame objesini buluyoruz
        Transform canvas = GameObject.Find("Canvas").transform; //Canvas objesini yakalýyoruz
        RestartGame = canvas.Find("RestartGame").gameObject;    // Canvas objesinin childi Restargame objesini yakalýyoruz (Obje pasif olduðu için Find komutu ile yapamýyoruz Null hatasý verir.
        
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
            
           
            RestartGame.SetActive(true); //RestartGame ekraný açýlacak.
            Time.timeScale = 0;       // Restartgame menusu açýlýnca oyunu durduran kod
            GreenPoisonBottle.fillAmount = 0.99f; // 1 de býrakýnca timescale 0 da kalýyor ve Restartlevel kodu timescale deðerini 1 yapýnca tekrar 0 yapýyor o yüzden bunu eklemek zorunda kaldýk.



        }
    }

    
}
