using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChainCollision : MonoBehaviour
{
    public GameOver gm;

    public Text recordText;

    public Text scoreText;

    public static int score = 0;

    void OnTriggerEnter2D (Collider2D col)
    {

        chain.IsFired = false;
        if(col.tag == "Ball") 
        {
            FindObjectOfType<AudioManagement>().Play("Bubble1");

            score = score + 1;

            scoreText.text = score.ToString();

            col.GetComponent<Ball>().Split();
        }

        


            if (score == 15 && col.tag == "Ball")
        {
            SceneManager.LoadScene(2);
        }

        if (score == 45 && col.tag == "Ball")
        {
            SceneManager.LoadScene(3);
        }

        if(score == 108 && col.tag == "Ball")
        {
            SceneManager.LoadScene(4);
        }

        if(score == 201 && col.tag == "Ball")
        {
            gm.Setup(score);
            recordText.text = "CONGRATS YOU WON THE GAME !";
        }

        void Start()
        {
            scoreText.text = score.ToString();
        }
    }

}