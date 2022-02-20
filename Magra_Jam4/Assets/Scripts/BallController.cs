using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;
    public Button basla;
    public Button hizlandir;

    private bool isnowfast;
    public float ballSpeedx;
    public float ballSpeedy;
    public int ballspeedtime;
    private Vector2 vector;
    private bool itclickedonce;
    private bool frozen;
    private bool itonceFrozen;
    public int ballFrozentime;

    public bool itstarted;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        basla.onClick.AddListener(Task1OnClick);
        hizlandir.onClick.AddListener(Task2OnClick);

        itclickedonce = false;
        isnowfast = false;
        itstarted = false;
    }
    void FixedUpdate()
    {

        StartCoroutine(fastballtime());

    }
    void Task1OnClick()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
        itstarted = true;
    }
    void Task2OnClick()
    {
        if (itclickedonce==false)
        {
            isnowfast = true;
            itclickedonce = true;
            if (isnowfast)
            {
                rb.velocity = new Vector2(rb.velocity.x * ballSpeedx, rb.velocity.y * ballSpeedy);
            }
        }
        
    }


    IEnumerator fastballtime()
    {
        if (isnowfast)
        {
            yield return new WaitForSeconds(ballspeedtime);
            isnowfast = false;
            itclickedonce = false;
               
        }
        
    }

}