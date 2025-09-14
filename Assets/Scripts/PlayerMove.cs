using Unity.VisualScripting;
using UnityEngine;



public class PlayerMove : MonoBehaviour
{

   public float speed = 0.5f;

    bool goLeft = true;
    bool goRight = true;
    bool goUp = true;
    bool goDown = true;

  

    private SpriteRenderer spriteRenderer;



    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentpos = transform.position;
        float moveX = 0f; // Track horizontal movement

        if (Input.GetKey(KeyCode.W) && goUp)
        {
            currentpos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S) && goDown)
        {
            currentpos.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) && goRight)
        {
            currentpos.x += speed * Time.deltaTime;
            moveX = 1f; // Moving right
        }

        if (Input.GetKey(KeyCode.A) && goLeft)
        {
            currentpos.x -= speed * Time.deltaTime;
            moveX = -1f; // Moving left
        }

        transform.position = currentpos;

        // Flip sprite based on movement direction
        if (moveX > 0)
            spriteRenderer.flipX = false; // Facing right
        else if (moveX < 0)
            spriteRenderer.flipX = true;  // Facing left
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Left"))
        {
            goLeft = false;
        }

        if (collision.CompareTag("Right"))
        {
            goRight = false;
        }
        if (collision.CompareTag("Up"))
        {
            goUp = false;
        }
        if (collision.CompareTag("Down"))
        {
            goDown = false;
        }
    }

     void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Left"))
        {
            goLeft = true;
        }
        if (collision.CompareTag("Right"))
        {
            goRight = true;
        }
        if (collision.CompareTag("Up"))
        {
            goUp = true;
        }
        if (collision.CompareTag("Down"))
        {
            goDown = true;
        }
    }   
}
