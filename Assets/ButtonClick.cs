using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VoicevoxBridge;


public class ButtonClick : MonoBehaviour
{
    [SerializeField] VOICEVOX voicevox;

    public async void PlayVoice()
    {
        int speaker = 3; 
        string text = "こんにちは、初めまして";
        await voicevox.PlayOneShot(speaker, text);
    }
}



