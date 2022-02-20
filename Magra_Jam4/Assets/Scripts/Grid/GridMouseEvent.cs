using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMouseEvent : MonoBehaviour
{
    [SerializeField] private GameObject[] bloklar;
    GameObject suilet,obje;

    private void Update()
    {
        if (ToolManager.Instance.oyunBasladi)
        {
            Destroy(suilet);
            Destroy(gameObject);
        }
    }
    private void OnMouseEnter()
    {
        BlokSuilet();
    }

    private void OnMouseExit()
    {
        Destroy(suilet);
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BlokYerlestir();
        }
    }

    void BlokSuilet()
    {
        if(ToolManager.Instance.blokMiktari[ToolManager.Instance.seciliBlok] > 0)
        {
            suilet = Instantiate(bloklar[ToolManager.Instance.seciliBlok], new Vector3(transform.position.x, transform.position.y, -1), transform.rotation);
            suilet.transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color(0, 0, 100, 0.3f);
            suilet.GetComponent<Rigidbody2D>().gravityScale = 0;
            //suilet.GetComponent<Rigidbody2D>().isKinematic = true;
            try
            {
                Destroy(suilet.GetComponent<PolygonCollider2D>());
            }
            catch { }

            try
            {
                Destroy(suilet.GetComponent<BoxCollider2D>());
            }
            catch { }
        }

    }

    void BlokYerlestir()
    {
        if(ToolManager.Instance.blokMiktari[ToolManager.Instance.seciliBlok] > 0)
        {
            ToolManager.Instance.blokMiktari[ToolManager.Instance.seciliBlok] -= 1;
            obje = Instantiate(bloklar[ToolManager.Instance.seciliBlok], new Vector3(transform.position.x, transform.position.y, -1), transform.rotation);
            obje.GetComponent<Rigidbody2D>().gravityScale = 0;
            //obje.GetComponent<Rigidbody2D>().isKinematic = true;
        }
    }
}
