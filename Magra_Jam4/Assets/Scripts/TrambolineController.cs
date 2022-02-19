using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrambolineController : MonoBehaviour
{
    public int positions;
    public float trambolinebounce;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball"&& positions==1)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(collision.gameObject.GetComponent<Rigidbody2D>().velocity.x, collision.gameObject.GetComponent<Rigidbody2D>().velocity.y + trambolinebounce);
        }
        else if (collision.gameObject.tag == "Ball" && positions == 2)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(collision.gameObject.GetComponent<Rigidbody2D>().velocity.x+trambolinebounce, collision.gameObject.GetComponent<Rigidbody2D>().velocity.y );
        }
        else if (collision.gameObject.tag == "Ball" && positions == 3)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(collision.gameObject.GetComponent<Rigidbody2D>().velocity.x, collision.gameObject.GetComponent<Rigidbody2D>().velocity.y - trambolinebounce);
        }
        else if (collision.gameObject.tag == "Ball" && positions == 4)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(collision.gameObject.GetComponent<Rigidbody2D>().velocity.x - trambolinebounce, collision.gameObject.GetComponent<Rigidbody2D>().velocity.y );
        }
    }
}
