using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    public GameObject textC;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        textC.gameObject.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        textC.gameObject.SetActive(false); 
    }
}
