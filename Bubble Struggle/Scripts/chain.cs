using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chain : MonoBehaviour
{
    public GameOver gm;

    public static bool IsFired = false;

    public float speed = 2f;

    public Transform player;    
    // Start is called before the first frame update
    void Start()
    {
        IsFired = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (gm.isGameOver == false)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                IsFired = true;
            }

            if (IsFired)
            {
                transform.localScale += Vector3.up * Time.deltaTime * speed;    //Oluşturduğumuz çizgi, kullanıcı bastığı yerde yavaşça oluşacak.
            }
            else
            {
                transform.position = player.position;
                transform.localScale = new Vector3(1f, 0f, 1f);

            }


        }
        
    }
}
