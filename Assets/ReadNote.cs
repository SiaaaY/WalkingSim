using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadNote : MonoBehaviour
{
    public GameObject player;
    public GameObject noteUI;
    public GameObject pickUpText;

    public AudioSource pickUpSound;

    public bool inReach;

    // Start is called before the first frame update
    void Start()
    {
        noteUI.SetActive(false);
        pickUpText.SetActive(false);

        inReach = false;
        
    }

    void OnTriggerEnter(Collider other) {
        
        if (other.gameObject.tag == "Reach"){
            inReach = true;
            pickUpText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other) {
        
        if (other.gameObject.tag == "Reach"){
            inReach = false;
        }
        
    }
        

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && inReach)
        {
           noteUI.SetActive(true);
        }

        if (Input.GetMouseButtonUp(1))
        {
            noteUI.SetActive(false);
        }
    }
}
