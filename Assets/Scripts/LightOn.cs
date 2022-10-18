using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOn : MonoBehaviour
{
    public GameObject txtToDisplay; //display UI
    private bool PlayerInZone; //detect player for trigger
    public GameObject lightorobj;

    // Start is called before the first frame update
    void Start()
    {
        PlayerInZone = false;
        txtToDisplay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerInZone && Input.GetKeyDown(KeyCode.F)) //check if player in zone 
                                                       //and F pressed
        {
            lightorobj.SetActive(!lightorobj.activeSelf);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            txtToDisplay.SetActive(true);
            PlayerInZone = true;
        }   
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerInZone = false;
            txtToDisplay.SetActive(false);
        }
    }
}



    