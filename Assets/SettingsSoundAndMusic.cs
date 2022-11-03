using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    /*private static readonly string FirstPlay = "FirstPlay";
    private static readonly string MusicPref = "MusicPref";
    private static readonly string SoundsPref = "SoundsPref";
    private int firstPlayInt;
    public Slider MusicSlider;
    public Slider Sounds;
    private float MusicFloat, SoundsFloat;
    public AudioSource MusicAudio;
    public AudioSource[] SoundsAudio;*/
    public AudioMixer audioMixer;

    void Start()
    {
        /* MusicAudio = GetComponent<AudioSource>();
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);
        if (firstPlayInt == 0)
        {
            MusicFloat = .125f;
            SoundsFloat = .75f;
            MusicSlider.value = MusicFloat;
            Sounds.value = SoundsFloat;
            PlayerPrefs.SetFloat(MusicPref, MusicFloat);
            PlayerPrefs.SetFloat(SoundsPref, SoundsFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            MusicFloat = PlayerPrefs.GetFloat(MusicPref);
            MusicSlider.value = MusicFloat;
            SoundsFloat = PlayerPrefs.GetFloat(SoundsPref);
            Sounds.value = SoundsFloat;
        }*/
    }


    /*public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(MusicPref, MusicSlider.value);
        PlayerPrefs.SetFloat(SoundsPref, Sounds.value);
    }

    public void OnApplicationFocus(bool inFocus)
    {
        if(!inFocus)
        {
            SaveSoundSettings();
        }
    }

    public void UpdateSound()
    {
        MusicAudio.volume = MusicSlider.value;
        for (int i = 0; i < SoundsAudio.Length; i++)
        {
            //SoundsAudio[i] = Sounds.value;
        }
    }*/

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
