using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    // Start is called before the first frame update
    private float rotateSpeed;
    private void Awake(){
        rotateSpeed = Random.Range(0,360);
    }
    private void Update() {
        transform.Rotate(Vector3.back*rotateSpeed*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player"){
            HeartSetting.heart += 1;
            PlayerScript.heart=true;
            Destroy(gameObject);
        }
    }
}
