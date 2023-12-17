using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScare2 : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource audioSource2;
    // [SerializeField] private Animator animator;

    [SerializeField] AudioClip ahClip;
    [SerializeField] AudioClip ah2Clip;
    [SerializeField] AudioClip ah3Clip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //animator.SetBool("boo", true);
            PlayAhSound();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        audioSource2.PlayOneShot(ah2Clip);
        audioSource2.PlayOneShot(ah3Clip);

        Destroy(audioSource);
        Destroy(gameObject);

    }
    public void PlayAhSound()
    {
        audioSource.PlayOneShot(ahClip);
       
    }
}
