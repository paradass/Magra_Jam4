using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransform : MonoBehaviour
{
    [SerializeField] private int blokNo;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (ToolManager.Instance.oyunBasladi)
        {
            GetComponent<Rigidbody2D>().isKinematic = false;
            GetComponent<Rigidbody2D>().gravityScale = 1;
            if(gameObject.tag == "Tahta")
            {
                transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            }
            Destroy(this);
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(0, 0, -90);
        }
        else if (Input.GetMouseButton(1))
        {
            ToolManager.Instance.blokMiktari[blokNo] += 1;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color(100, 0, 0, 0.5f);
        ToolManager.Instance.oyunBaslayabilirmi = false;

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color(100, 0, 0, 0.5f);
        ToolManager.Instance.oyunBaslayabilirmi = false;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        ToolManager.Instance.oyunBaslayabilirmi = true;
    }
}
