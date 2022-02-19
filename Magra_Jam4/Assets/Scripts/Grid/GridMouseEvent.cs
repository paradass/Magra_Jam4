using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMouseEvent : MonoBehaviour
{
    [SerializeField] private GameObject blok;

    private void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.3f);
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            for(int i = 0;i < transform.childCount; i++)
            {
                Destroy(transform.GetChild(i).gameObject);
            }
            GameObject obje = Instantiate(blok, new Vector3(transform.position.x,transform.position.y,-1) ,transform.rotation);
            obje.transform.parent = transform;
        }
    }
}
