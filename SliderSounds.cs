using UnityEngine;
using UnityEngine.UI;

public class SliderSounds : MonoBehaviour
{
    private AudioSource MainMenuMusic;
    private Slider MainMenuMusicSlider;
    private Image SliderColor;
    

    private float volume; // kaydedilen ses seviyesi

    
    void Start()
    {
        Image[] allImages = gameObject.GetComponentsInChildren<Image>();
        SliderColor = allImages[1];

        MainMenuMusic = GetComponent<AudioSource>();
        MainMenuMusicSlider = GetComponentInChildren<Slider>();

        // kaydedilmiþ ses seviyesini yükle
        volume = PlayerPrefs.GetFloat("Volume", 1f); // 1f default deðerdir.

        // slider'ýn deðerini kaydedilmiþ ses seviyesine eþitle
        MainMenuMusicSlider.value = volume;

        // müzik ses seviyesini ayarla
        MainMenuMusic.volume = volume;

        // slider'ýn deðiþimini dinle
        MainMenuMusicSlider.onValueChanged.AddListener(OnVolumeChanged);
    }

    private void FixedUpdate()
    {
        
        if(MainMenuMusicSlider.value == 0)
        {
            SliderColor.color = Color.red;
        }

        else
        {
            SliderColor.color = Color.green;
        }
        
    }

    // slider deðeri deðiþtiðinde çalýþacak metod
    void OnVolumeChanged(float value)
    {
        // ses seviyesini ayarla
        MainMenuMusic.volume = value;

        // kaydet
        PlayerPrefs.SetFloat("Volume", value);
    }

    
}