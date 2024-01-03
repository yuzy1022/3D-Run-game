using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRemove : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "CannonBullet"){
            Destroy(other.gameObject);
        }
    }
    // Update is called once per frame

}
