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
            Destroy(this);
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(0, 0, 90);
        }
        else if (Input.GetMouseButton(1))
        {
            ToolManager.Instance.blokMiktari[blokNo] += 1;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<ObjectTransform>())
        {
            ToolManager.Instance.blokMiktari[blokNo] += 1;
            Destroy(gameObject);
        }

    }
}
