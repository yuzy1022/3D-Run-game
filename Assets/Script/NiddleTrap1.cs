using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NiddleTrap1 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player" && PlayerScript.trap==0){
            PlayerScript.trap=1;
        }
    }
    /*private void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "Player"){
            PlayerScript.trap=0;
        }
    }*/
}
