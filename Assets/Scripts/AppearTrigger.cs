using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearTrigger : MonoBehaviour
{
    public GameObject _gameObject;
  
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
       
        _gameObject.gameObject.SetActive(true);            
        
    }

    private void OnTriggerExit(Collider other)
    {        
        _gameObject.gameObject.SetActive(false); 
    }
}
