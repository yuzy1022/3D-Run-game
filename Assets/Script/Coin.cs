using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float rotateSpeed;
    private void Awake(){
        rotateSpeed = Random.Range(0,360);
    }
    private void Update() {
        transform.Rotate(Vector3.back*rotateSpeed*Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player"){
            ScoreSetting.score += 1;
            PlayerScript.coin=true;
            Destroy(gameObject);
        }
    }
}
