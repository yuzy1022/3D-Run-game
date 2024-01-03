using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBullet : MonoBehaviour
{
    // Start is called before the first frame updat
    public float speed;

    private void Update() {
        //Vector3 dir = transform.forward ;
        //transform.position += dir * speed * Time.deltaTime;
        //gameObject.GetComponent<Rigidbody>().velocity = dir * speed;
    }

    private void Start() {
        Vector3 dir = transform.forward ;
        gameObject.GetComponent<Rigidbody>().velocity = dir * speed;
    }

    private void OnCollisionEnter(Collision other) {
        Destroy(gameObject, 0.05f);
        if(PlayerScript.trap==0 && other.gameObject.tag=="Player"){PlayerScript.trap=1;}
    }

    private void OnCollisionExit(Collision other) {
        if(PlayerScript.trap==2 && other.gameObject.tag=="Player"){PlayerScript.trap=0;}
    }
    // Update is called once per frame
}
