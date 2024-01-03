using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Transform target;
    public AudioSource audioSource;
    public AudioClip sound;
    bool f=false;
    int s=0;
    private float rotateSpeed;
    private void Awake(){
        rotateSpeed = Random.Range(0,360);
    }
    private void Update() {
        if(f){
        Vector3 dir = target.transform.position- transform.position;
        gameObject.GetComponent<Rigidbody>().velocity = dir * speed;
        }
        transform.Rotate(Vector3.forward*rotateSpeed*Time.deltaTime);
        if(s==1){audioSource.PlayOneShot(sound); s=2;}
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="MazeFloor"){f=true;}
        if(s==0){ s=1;}
        if(other.gameObject.tag=="Player"){PlayerScript.gameOver=true;}
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Target"){Destroy(gameObject);}
    }
}
