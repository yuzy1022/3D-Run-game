using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;
    public GameObject effect;
    public AudioClip effectSound;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("cannonShooting", 0, 5);
    }

    // Update is called once per frame
    void cannonShooting(){
        Instantiate(bullet, firePos.transform.position, firePos.transform.rotation);
        Instantiate(effect, firePos.transform.position, firePos.transform.rotation);
        audioSource.PlayOneShot(effectSound);
        }
}
