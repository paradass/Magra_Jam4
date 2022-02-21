using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolsButton : MonoBehaviour
{
    [SerializeField] private int toolNo;
    Text miktar;

    private void Start()
    {
        miktar = transform.GetChild(1).transform.gameObject.GetComponent<Text>();
    }

    private void Update()
    {
        miktar.text = ToolManager.Instance.blokMiktari[toolNo].ToString();
        if (ToolManager.Instance.oyunBasladi)
        {
            Destroy(gameObject);
        }
    }
    public void ButonSec()
    {
        if(ToolManager.Instance.seciliBlok == toolNo)
        {
            ToolManager.Instance.ButonSec(toolNo);
            ToolManager.Instance.seciliBlok = -1;
        }
        else
        {
            ToolManager.Instance.ButonSec(toolNo);
        }
    }
}
