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

        // kaydedilmi� ses seviyesini y�kle
        volume = PlayerPrefs.GetFloat("Volume", 1f); // 1f default de�erdir.

        // slider'�n de�erini kaydedilmi� ses seviyesine e�itle
        MainMenuMusicSlider.value = volume;

        // m�zik ses seviyesini ayarla
        MainMenuMusic.volume = volume;

        // slider'�n de�i�imini dinle
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

    // slider de�eri de�i�ti�inde �al��acak metod
    void OnVolumeChanged(float value)
    {
        // ses seviyesini ayarla
        MainMenuMusic.volume = value;

        // kaydet
        PlayerPrefs.SetFloat("Volume", value);
    }

    
}