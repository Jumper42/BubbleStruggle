using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{

    public ChainCollision ChainCollision;

    public Player Player;

    public void PlayGame ()
    {
        SceneManager.LoadScene(1);
        Player.heartCount = 3;
    }

    public void QuitGame ()
    { 
        Application.Quit();
    }

}
