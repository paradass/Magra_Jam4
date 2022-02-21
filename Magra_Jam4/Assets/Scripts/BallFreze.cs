using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallFreze : MonoBehaviour
{
 private Rigidbody2D rbody;
    public Button donma;
    public bool isfrozen;
    private bool isforzenonce;
    public int bollfrozentime;
    public int howmuchfrezewehave;
    private int howmuchtimewehavecounter;
    public GameObject buttontext;
    public BallController bc;
    private int counterinCoroutime;
    private int bollfrozentimebox;
    public Sprite frezesprite;
    private Sprite actualsprite;
    //turing
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        isfrozen = false;
        isforzenonce = false;
        donma.onClick.AddListener(Task1Listemer);
        actualsprite = GetComponent<SpriteRenderer>().sprite;
    }


    void Update()
    {
        buttontext.GetComponent<Text>().text ="Dondur "+(howmuchfrezewehave - howmuchtimewehavecounter).ToString();
        StartCoroutine(donmaop());   
    }

    void Task1Listemer()
    {
        rbody.velocity = new Vector2(0, 0);
        rbody.bodyType = RigidbodyType2D.Static;
        isfrozen = true;
        isforzenonce = false;
        howmuchtimewehavecounter++;
        if (howmuchtimewehavecounter >= howmuchfrezewehave)
        {
            donma.gameObject.SetActive(false);
        }
    }
    IEnumerator donmaop()
    {
        if (isfrozen && isforzenonce == false && howmuchfrezewehave >= howmuchtimewehavecounter && bc.itstarted)
        {

             isforzenonce = true;
            GetComponent<SpriteRenderer>().sprite = frezesprite;
             bollfrozentimebox = bollfrozentimebox + bollfrozentime;
            for (int i = 0; i < bollfrozentimebox; i++)
            {
                yield return new WaitForSeconds(1f);
            }
            GetComponent<SpriteRenderer>().sprite = actualsprite;
            rbody.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}