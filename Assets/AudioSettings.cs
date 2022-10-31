using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    private static readonly string MusicPref = "MusicPref";
    private static readonly string SoundsPref = "SoundsPref";
    private float MusicFloat, SoundsFloat;
    public AudioSource[] MusicAudio;
    public AudioSource[] SoundsAudio;
    // Start is called before the first frame update
    void Awake()
    {
        ContinueSettings();
    }

    private void ContinueSettings()
    {
        MusicFloat = PlayerPrefs.GetFloat(MusicPref);
        SoundsFloat = PlayerPrefs.GetFloat(SoundsPref);
        /*MusicAudio.volume = MusicFloat;
        for (int i = 0; i < SoundsAudio.Length; i++)
        {
            SoundsAudio[i] = SoundsFloat;
        }*/
    }
}
