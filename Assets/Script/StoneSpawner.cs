using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpawner : MonoBehaviour
{
    public Transform Spawn;
    public GameObject Stone;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("StoneSpawn", 0f, 7f);
    }

    // Update is called once per frame
    void StoneSpawn(){
        Instantiate(Stone, Spawn.transform.position, Spawn.transform.rotation);
    }
}
