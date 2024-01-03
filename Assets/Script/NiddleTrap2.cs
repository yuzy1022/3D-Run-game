using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NiddleTrap2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "Player" && PlayerScript.trap==2){
            PlayerScript.trap=0;
        }
    }
}
