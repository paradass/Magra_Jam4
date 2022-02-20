using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolManager : MonoBehaviour
{
    private static ToolManager _instance;
    public static ToolManager Instance => _instance;
    public int seciliBlok = 0;
    public int[] blokMiktari;
    [SerializeField] private Button[] butonlar;
    public bool oyunBaslayabilirmi = true,oyunBasladi;

    void Start()
    {
        _instance = this;
    }

    
    void Update()
    {
        
    }

    public void ButonSec(int blokNumarasi)
    {
        ResetButtonAnimations();
        seciliBlok = blokNumarasi;
        butonlar[seciliBlok].GetComponent<Animator>().Play("Button Select");
    }

    void ResetButtonAnimations()
    {
        for(int i = 0; i < butonlar.Length; i++)
        {
            butonlar[i].GetComponent<Animator>().Play("Idle");
        }
    }
}
