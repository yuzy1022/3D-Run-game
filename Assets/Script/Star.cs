using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    // Start is called before the first frame update
    private float rotateSpeed;
    private void Awake(){
        rotateSpeed = Random.Range(0,360);
    }
    private void Update() {
        transform.Rotate(Vector3.back*rotateSpeed*Time.deltaTime);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Player"){
            PlayerScript.goal=true;
            PlayerScript.star=true;
            Destroy(gameObject);
            }
    }
}
