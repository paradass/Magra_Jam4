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
    }
    public void ButonSec()
    {
        ToolManager.Instance.ButonSec(toolNo);
    }
}
