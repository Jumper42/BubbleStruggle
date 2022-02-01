using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{

    
    public Player Player;

    public chain chain;

    public bool isGameOver = false; 

    public Text pointsText;

    public Text highScore;

    [SerializeField]

    public GameObject GameOverScreen;

 
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void Setup(int score)
    {


        if (!isGameOver)    
        {
            Time.timeScale = 0f;

            FindObjectOfType<AudioManagement>().Play("gamerDie");//Oyuncu öldüðünde bu ses çýkacak


            GameOverScreen.SetActive(true);
            
            pointsText.text = score.ToString() + " POINTS";
            
            isGameOver = true;
            
            Player.speed = 0f;
            
            Player.heartCount = 0;

            //chain.transform.localScale = Vector3.up * 0;


            if (score > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", score);
                highScore.text = score.ToString();
            }
            
        }


    }

    public void RestartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
        Player.heartCount = 3;
    }

    public void MenuButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu" );
    }

}
