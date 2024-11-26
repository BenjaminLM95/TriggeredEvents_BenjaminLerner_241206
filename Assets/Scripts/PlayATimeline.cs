using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayATimeline : MonoBehaviour
{
    public PlayableDirector pdTimeline;
    public bool played; 
    // Start is called before the first frame update
    void Start()
    {
        played = false; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            Debug.Log("Trigger"); 
            if (!played) 
            {
                pdTimeline.Play();
                played = true; 
            }
        }
    }
}
