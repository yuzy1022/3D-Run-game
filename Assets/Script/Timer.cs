using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float time;
    public static int rTime;
    const int settingTime = 3;
    static int m;
    static int s;
    static bool timeOver;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        m = settingTime;
        s = 0;
        timeOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerScript.goal == false){ 
            time += Time.deltaTime;  
        }

        if(Mathf.FloorToInt(time)%60 == 0 && !timeOver){s = 0;}
        else {s = 60 - Mathf.FloorToInt(time)%60;}

        if(Mathf.FloorToInt(time)%60 > 0  && !timeOver){
            m = (settingTime-1) - Mathf.FloorToInt(time/60);
        }
        else if(Mathf.FloorToInt(time)%60 == 0 && !timeOver) {
            m = settingTime - Mathf.FloorToInt(time/60);
        }
        
        if(PlayerScript.goal == false && time > settingTime * 60){
            timeOver=true;
            s=0; m=0;
            PlayerScript.gameOver=true;
        }
        
        Text uiText = GetComponent<Text>();
        if (s > 9){
            uiText.text = "0" + m.ToString() + ":" + s.ToString();
        }
        else {
            uiText.text = "0" + m.ToString() + ":0" + s.ToString();
        }

        if(PlayerScript.goal==true){
            rTime=Mathf.FloorToInt((settingTime*60-time)*100);
        }
        
    }
}
