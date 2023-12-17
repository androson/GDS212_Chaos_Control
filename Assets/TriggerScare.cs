using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class TriggerScare : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
   // [SerializeField] private Animator animator;

    [SerializeField] AudioClip ahClip;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //animator.SetBool("boo", true);
            PlayAhSound();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            
            Destroy(gameObject);
          
        }
    }

    public void PlayAhSound()
    {
        audioSource.PlayOneShot(ahClip);
    }
}
