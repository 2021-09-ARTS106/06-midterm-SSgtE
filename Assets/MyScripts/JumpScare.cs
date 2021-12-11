using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip audioClip;
    public GameObject JumpSoundzone2;
    private bool playScare = true;


    private void OnTriggerEnter()
    {
        audioSource.Play();
       
    }



    private void OnTriggerExit()
    {
        Destroy(JumpSoundzone2);
    }

}
