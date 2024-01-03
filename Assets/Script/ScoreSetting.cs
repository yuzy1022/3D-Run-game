using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSetting : MonoBehaviour
{
    public static int score;
    public Text scoreTt;
    // Start is called before the first frame update
    void Start()
    {
        score=0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreTt.text= "Coin:" + score.ToString();
    }
}
