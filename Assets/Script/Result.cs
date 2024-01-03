using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    public GameObject ResultParts;
    public Text heartText;
    public Text timeText;
    public Text coinText;
    public Text totalText;
    public Text bestText;
    private int bestScore;

    private void Start() {
        if (PlayerPrefs.HasKey("BestScore")){ //HasKey는 DB없이 간단한 데이터를 저장할수 있다. , HighScore값이 있는지 검사
            bestScore = PlayerPrefs.GetInt("BestScore");
        }
        else
        {
            bestScore = 0;  
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(PlayerScript.goal==true){
            ResultParts.SetActive(true);
            int heart = HeartSetting.heart * 2000;
            int coin = ScoreSetting.score * 1500;
            int time = Timer.rTime;
            int total = heart+time+coin;
            if (bestScore < total){
                PlayerPrefs.SetInt("BestScore", total);  //result를 HighScore의 키값으로 레지스트리에 저장
            }
            heartText.text = "Heart Score\n" + heart;
            timeText.text = "Time Score\n" + time;
            coinText.text = "Coin Score\n" + coin;
            totalText.text = "Total Score\n" + total;
            bestText.text = "BestScore\n" + bestScore;
            Cursor.visible=true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
        }

    }

    public void OnRetry()  //다시시작 버튼을 눌렀을 때 호출되는 함수
    {   
        PlayerScript.gameOver=false;
        PlayerScript.goal=false;
        Time.timeScale = 1;
        Cursor.visible=false;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene("Game");
        
    }
}
