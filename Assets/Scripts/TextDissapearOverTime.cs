using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDissapearOverTime : MonoBehaviour
{
    public float overTime = 5f;
    public float triggerTime;
    public bool Activate = true; 

    // Start is called before the first frame update
    void Start()
    {
        overTime = 10f; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Activate) 
        {
            triggerTime = Time.time + overTime;
            Activate = false; 
        }

        if(Time.time > triggerTime) 
        {             
            this.gameObject.SetActive(false); 
        }
        
    }
}
