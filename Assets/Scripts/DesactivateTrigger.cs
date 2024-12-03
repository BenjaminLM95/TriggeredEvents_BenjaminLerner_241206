using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DesactivateTrigger : MonoBehaviour
{
    public GameObject _objectToDesappear;
    private bool activated;
    public Controller controller;
    public GameObject player;
    public TextMeshProUGUI msg;
    
    // Start is called before the first frame update

    private void Start()
    {
        controller = player.GetComponent<Controller>(); 
        activated = false; 

    }
    private void OnTriggerEnter(Collider other)
    {

        if(controller.nSouls >= controller.mxSouls - 2) 
        {
            if (other.gameObject.CompareTag("Player") && !activated) 
            {            
            _objectToDesappear.gameObject.SetActive(false);
            activated = true;
                msg.gameObject.SetActive(true);
                msg.text = "Something happened! Go outside and look around!";
            }
        }
        else 
        {
            msg.gameObject.SetActive(true);
            msg.text = "You have insufficient amount of souls. Collect at least " + (controller.mxSouls - 2).ToString();
        }
        
        
    }

    private void OnTriggerExit(Collider other)
    {
        msg.gameObject.SetActive(false); 
    }

}
