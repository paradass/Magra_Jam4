using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallFreze : MonoBehaviour
{
 private Rigidbody2D rbody;
    public Button donma;
    private bool isfrozen;
    private bool isforzenonce;
    public int bollfrozentime;
    //turing
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        isfrozen = false;
        isforzenonce = false;
        donma.onClick.AddListener(Task1Listemer);
    }


    void Update()
    {
        StartCoroutine(donmaop());
    }
    void Task1Listemer()
    {
        if (isforzenonce == false)
        {
            rbody.velocity = new Vector2(0, 0);
            rbody.bodyType = RigidbodyType2D.Static;
            isfrozen = true;
            isforzenonce = true;
        }
    }
    IEnumerator donmaop()
    {
        if (isfrozen)
        {
            for (int i = 0; i < bollfrozentime; i++)
            {
                yield return new WaitForSeconds(1f);
            }
            isforzenonce = false;
            rbody.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}