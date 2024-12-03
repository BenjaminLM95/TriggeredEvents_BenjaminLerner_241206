using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearTrigger : MonoBehaviour
{
    public GameObject _gameObject;
    private bool happened = false; 
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (!happened)
        {
            _gameObject.gameObject.SetActive(true);
            happened = true; 
        }
    }

    private void OnTriggerExit(Collider other)
    {        
        _gameObject.gameObject.SetActive(false); 
    }
}
