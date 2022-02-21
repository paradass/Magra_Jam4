using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;
    public Button basla;
    public Button hizlandir;
    public Text hata;


    public float ballSpeedx;
    public float ballSpeedy;
    public int ballspeedtime;
    private Vector2 vector;

    public int ballFrozentime;

    public bool itstarted;
    public ToolManager Tm;
    public Button ballFreze;

    public int howmuchballcanbefast;
    private int howmuchballcanbefastbox;
    public GameObject buttontext;
    public float dashtimes;
    private bool candash;

    public float dashnumber;
    private float dashnumberbox;

    public GameObject sampleball;
    public Color[] color;
    private GameObject sampleballxd;

    private Color acolor;
    public BallFreze bf;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        basla.onClick.AddListener(Task1OnClick);
        hizlandir.onClick.AddListener(Task2OnClick);

        itstarted = false;
        buttontext.GetComponent<Text>().text = "H�zland�r " + (howmuchballcanbefast);
        acolor = sampleball.GetComponent<SpriteRenderer>().color;
    }
    void Update()
    {
        if (candash)
        {
            if (dashnumberbox < dashnumber&&bf.isfrozen==false)
            {
                dashnumberbox=dashnumberbox+0.1f;
                acolor = color[Random.Range(0, color.Length)];
                acolor.a = 0.2f;
                sampleball.GetComponent<SpriteRenderer>().color = acolor;
                GameObject ins = Instantiate(sampleball, new Vector3(transform.position.x, transform.position.y,0), transform.rotation);
                Destroy(ins, 2f);
            }
        }
        else 
        {
            dashnumberbox = 0;
        }
    }

    void Task1OnClick()
    {
        if (ToolManager.Instance.oyunBaslayabilirmi)
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            itstarted = true;
            basla.gameObject.SetActive(false);

            ballFreze.gameObject.SetActive(true);
            hizlandir.gameObject.SetActive(true);
            Tm.oyunBasladi = true;
            hata.gameObject.SetActive(false);
        }
        else
        {
            hata.gameObject.SetActive(true);
            Invoke("HataSonlandir", 3);
        }
    }
    void Task2OnClick()
    {
        StartCoroutine(dashtime());
        if (howmuchballcanbefast-1 > howmuchballcanbefastbox)
        {
            rb.velocity = new Vector2(rb.velocity.x * ballSpeedx, rb.velocity.y * ballSpeedy);
            howmuchballcanbefastbox++;
            buttontext.GetComponent<Text>().text ="H�zland�r "+(howmuchballcanbefast - howmuchballcanbefastbox).ToString(); 
        }
        else
        {
            hizlandir.gameObject.SetActive(false);
        }
    }
    IEnumerator dashtime()
    {
        candash = true;
        yield return new WaitForSeconds(dashtimes);
        candash = false;
    }

    void HataSonlandir()
    {
        hata.gameObject.SetActive(false);
    }
}