using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSmelter : MonoBehaviour
{
    public float airspeedx;
    public float airspeedy;

    public int position;

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Ball" && position==1)
        {
            collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(collider.gameObject.GetComponent<Rigidbody2D>().velocity.x+airspeedx*Time.deltaTime,collider.gameObject.GetComponent<Rigidbody2D>().velocity.y+airspeedy*Time.deltaTime);
        }
        else if (collider.gameObject.tag == "Ball" && position == 2)
        {
            collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(collider.gameObject.GetComponent<Rigidbody2D>().velocity.x - airspeedx * Time.deltaTime, collider.gameObject.GetComponent<Rigidbody2D>().velocity.y + airspeedy * Time.deltaTime);
        }
        else if (collider.gameObject.tag == "Ball" && position == 3)
        {
            collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(collider.gameObject.GetComponent<Rigidbody2D>().velocity.x  , collider.gameObject.GetComponent<Rigidbody2D>().velocity.y + airspeedy * Time.deltaTime);
        }
        else if (collider.gameObject.tag == "Ball" && position == 4)
        {
            collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(collider.gameObject.GetComponent<Rigidbody2D>().velocity.x , collider.gameObject.GetComponent<Rigidbody2D>().velocity.y - airspeedy * Time.deltaTime);
        }
    }
}
