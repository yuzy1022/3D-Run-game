using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverParts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerScript.gameOver){
            gameOverParts.SetActive(true);
            Cursor.visible=true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
        }
    }
    public void OnRetry()  //다시시작 버튼을 눌렀을 때 호출되는 함수
    {   
        SceneManager.LoadScene("Game");
        PlayerScript.gameOver=false;
        Time.timeScale = 1;
        Cursor.visible=false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
