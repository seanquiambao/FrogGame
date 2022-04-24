using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score;
    private bool isDead = false;
    private float timer = 0f;

    public Text scoreText;
    public Player player;
    public LevelGeneratorScript levelgenerator;
    public GameObject playButton;
    public GameObject retryButton;
    public GameObject gameOver;
    private AudioSource gameoverSound;

    private void Awake(){
        gameOver.SetActive(false);
        
        retryButton.SetActive(false);
        gameoverSound = GetComponent<AudioSource>();
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Play(){
        
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
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

    public void resetScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOver(){
        gameOver.SetActive(true);
        retryButton.SetActive(true);
        gameoverSound.Play();

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
