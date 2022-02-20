using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Rigidbody2D rb;
    public int customStoptime;
    private bool isStopped;
    public BallController bc;
    public float howmuchgameended;
    private bool nowincoroutime;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isStopped = false;
        nowincoroutime = false;
    }

    void Update()
    {
        CoroutimeCont();
    }
    void CoroutimeCont()
    {
        if (isStopped == false&&nowincoroutime==false)
        {
            StartCoroutine(CheckingBallStops());
        }
    }

    
    IEnumerator CheckingBallStops()
    {
        if (rb.velocity.x == 0 && rb.velocity.y == 0 && bc.itstarted == true)
        {
            nowincoroutime = true;
            for (int i = 0; i < customStoptime; i++)
            {
                yield return new WaitForSeconds(1f);
                if (rb.velocity.x != 0 || rb.velocity.y != 0)
                {
                    isStopped = false;
                    break;
                }
                isStopped = true;
                howmuchgameended = 1;
            }
            nowincoroutime = false;
        }
        if (isStopped && howmuchgameended == 1)
        {
            Debug.Log("oyun ptti");
            howmuchgameended = 2;
        }
    }
}
