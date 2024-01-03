using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    public float delay;
    public GameObject[] obj = new GameObject[20];
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DelayObject", delay);
    }

    // Update is called once per frame
    void DelayObject(){
        for(int i=0; i<obj.Length; i++){
            obj[i].SetActive(true);
        }
    }
}
