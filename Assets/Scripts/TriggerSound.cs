using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    public AudioSource auSource;
    public AudioClip auClip; 

    // Start is called before the first frame update
    void Start()
    {
        auSource = GetComponent<AudioSource>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            auSource.clip = auClip;
            auSource.Play();
            
        }
    }
}
