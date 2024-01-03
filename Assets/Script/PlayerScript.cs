using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip coinSound;
    public AudioClip damageSound;
    public AudioClip HP_Recovery;
    public AudioClip starSound;
    public static bool coin;
    public static int trap;
    public static bool goal;
    public static bool gameOver;
    public static bool heart;
    public static bool star;

    private void Start(){
        coin = false;
        trap = 0;
        goal = false;
        gameOver = false;
        heart = false;
    }
    private void Update() {
        if(coin){
            audioSource.PlayOneShot(coinSound);
            coin=false;
        }

        if(trap==1){
            audioSource.PlayOneShot(damageSound);
            if(HeartSetting.heart >= 0){
                HeartSetting.heart -= 1;
            }
            else {
                gameOver=true;
                }
            trap=2;
        }

        if(heart){
            audioSource.PlayOneShot(HP_Recovery);
            heart=false;
        }

        if(star){
            audioSource.PlayOneShot(starSound);
            star=false;
        }
    }
    // Start is called before the first frame update
}
