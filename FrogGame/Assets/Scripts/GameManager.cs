using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score;
    private bool isDead = false;
    private float timer = 0f;

    public Text scoreText;
    public Player player;
    public LevelGeneratorScript levelgenerator;
    public GameObject playButton;
    public GameObject gameOver;

    private void Awake(){
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Play(){
        
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;
        levelgenerator.enabled = true;
        

        
        


    }
    
    public void Pause(){
        Time.timeScale = 0f;
        
        
        player.enabled = false;
        levelgenerator.enabled = false;
    }

    public void increaseScoring(){
        score++;
        scoreText.text = score.ToString();
    }

    public void GameOver(){
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }

    void Update(){
        timer += Time.deltaTime;
        if(timer > 1f){
            
            if(!isDead){
                increaseScoring();
            }
            timer = 0f;
            
        }
        
    }
    
}
