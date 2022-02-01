using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public GameOver gm;

    public Text heartText;

    public static int heartCount = 3;

    public float speed = 4f;
    
    public Rigidbody2D rb;

    private float movement = 0f;
 
    // Update is called once per frame 
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal") * speed;

    }

    void Start()
    {
        heartText.text = heartCount.ToString();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2 (movement * Time.fixedDeltaTime,0f));
    }


    void OnCollisionEnter2D(Collision2D col)
    {

        
        if (col.collider.tag == "Ball")
        {
            if(heartCount > 0)
            {
                FindObjectOfType<AudioManagement>().Play("Enemyhit");
                heartCount = heartCount - 1;
                heartText.text = heartCount.ToString();
            }
        }


        if (heartCount == 0) 
        {
            
            gm.Setup(ChainCollision.score);
            
            ChainCollision.score = 0;

            //SceneManager.LoadScene("Menu");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}