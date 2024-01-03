using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartSetting : MonoBehaviour
{
    public static int heart;
    // Start is called before the first frame update
    void Start()
    {
        heart=3;
    }

    // Update is called once per frame
    void Update()
    {
        Text heartTt = GetComponent<Text>();
        switch(heart){
            case 0: 
                heartTt.text= "";
                break;
            case 1: 
                heartTt.text= "♥";
                break;
            case 2:
                heartTt.text= "♥♥";
                break;
            case 3:
                heartTt.text= "♥♥♥";
                break;
                case 4:
                heartTt.text= "♥♥♥♥";
                break;
        }

        if (heart < 0){
            PlayerScript.gameOver=true;
        }
    }
}
