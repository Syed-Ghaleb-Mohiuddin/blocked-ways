using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManagement : MonoBehaviour
{
    private AudioSource audioSource;
    private AudioSource CarSound;
    private AudioSource ClickSound;
    float musicVolume = 1f;
    float EffectsVolume = 1f;
    public Slider volumeSlider;
    public Slider volumeEffectsSlider;
    public GameObject ObjectMusic;
    void Start()
    {
        CarSound = GameObject.Find("Player").transform.Find("Car Sound").GetComponent<AudioSource>();
        ClickSound = GameObject.Find("Audio Source (1)").gameObject.GetComponent<AudioSource>();
        ObjectMusic = GameObject.FindWithTag("MusicPlayer");
        audioSource = ObjectMusic.GetComponent<AudioSource>();
        musicVolume = PlayerPrefs.GetFloat("volume");
        EffectsVolume = PlayerPrefs.GetFloat("effectsvolume");
        audioSource.volume = musicVolume;
        CarSound.volume = EffectsVolume;
        //ClickSound.volume = EffectsVolume;
        volumeSlider.value = musicVolume;
        volumeEffectsSlider.value = EffectsVolume;
    }

    void Update()
    {
        audioSource.volume = musicVolume;
        CarSound.volume = volumeEffectsSlider.value;
        //ClickSound.volume = volumeEffectsSlider.value;
        PlayerPrefs.SetFloat("volume", musicVolume);
        PlayerPrefs.SetFloat("effectsvolume", EffectsVolume);
    }
    public void updateVouleme(float volume)
    {
        musicVolume = volume;
    }    
    public void updateEffectsVouleme(float volume)
    {
        EffectsVolume = volume;
    }
}
