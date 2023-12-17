using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerJumpscare : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] private Animator animator;
    public GameObject character;
    public GameObject character2;

   [SerializeField] AudioClip ah2Clip;
   //[SerializeField] private AudioClip ah3Clip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            character.SetActive(true);
            //animator.SetBool("boo", true);
            //animator.SetTrigger("boo");
            PlayAh2Sound();
            character2.SetActive(false);
            /* if (animator.GetCurrentAnimatorStateInfo(0).IsName("bro"))
            {
               character.SetActive(false);
            }*/
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            character.SetActive(false);
            Destroy(gameObject);
            Destroy(character2);
        }
    }

    public void PlayAh2Sound()
    {
        audioSource.PlayOneShot(ah2Clip);
        //audioSource.PlayOneShot(ah3Clip);
    }
    /*
     * 
    private void Update()
    {
         if (animator.GetCurrentAnimatorStateInfo(0).IsName("idle"))
        {
            character.SetActive(false);
        }

    if (animator.GetCurrentAnimatorStateInfo(0).IsName("Jump"))
            {
                character.SetActive(true);
            }
            else
            {
                character.SetActive(false);
            }
}*/
}
