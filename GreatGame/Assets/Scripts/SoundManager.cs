using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip change_TimerBlock;
    static AudioSource audioSrc;
    void Start()
    {
        change_TimerBlock = Resources.Load<AudioClip> ("Change_TimerBlock");
        audioSrc = GetComponent<AudioSource> ();
    }
    void Update()
    {
        
    }
    public static void PlaySound (string clip){
        switch (clip) {
            case "Change_TimerBlock":
            audioSrc.PlayOneShot(change_TimerBlock);
            break;
        }
    }
}
