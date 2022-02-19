using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMouseEvent : MonoBehaviour
{
    [SerializeField] private GameObject blok,rampa,tuhaf,blokSuilet,rampaSuilet,tuhafSuilet;
    GameObject suilet,obje;

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
        if(ToolManager.Instance.seciliBlok == "Blok1")
        {
            suilet = Instantiate(blokSuilet, new Vector3(transform.position.x,transform.position.y,-1), transform.rotation);
        }
        else if (ToolManager.Instance.seciliBlok == "Blok2")
        {
            suilet = Instantiate(rampaSuilet, new Vector3(transform.position.x+0.2f, transform.position.y, -1), transform.rotation);
        }
        else if (ToolManager.Instance.seciliBlok == "Blok3")
        {
            suilet = Instantiate(tuhafSuilet, new Vector3(transform.position.x+0.2f, transform.position.y, -1), transform.rotation);
        }
    }

    void BlokYerlestir()
    {
        if (ToolManager.Instance.seciliBlok == "Blok1")
        {
            if(ToolManager.Instance.blok1Count > 0)
            {
                ToolManager.Instance.blok1Count--;
                obje = Instantiate(blok, new Vector3(transform.position.x, transform.position.y, -1), transform.rotation);
            }
            else
            {

            }
            
        }
        else if (ToolManager.Instance.seciliBlok == "Blok2")
        {
            if (ToolManager.Instance.blok1Count > 0)
            {
                ToolManager.Instance.blok1Count--;
                obje = Instantiate(rampa, new Vector3(transform.position.x+2.0f, transform.position.y, -1), transform.rotation);
            }
            else
            {

            }
        }
        else if (ToolManager.Instance.seciliBlok == "Blok3")
        {
            if (ToolManager.Instance.blok1Count > 0)
            {
                ToolManager.Instance.blok1Count--;
                obje = Instantiate(tuhaf, new Vector3(transform.position.x+2.0f, transform.position.y, -1), transform.rotation);
            }
            else
            {

            }
        }
    }
}
