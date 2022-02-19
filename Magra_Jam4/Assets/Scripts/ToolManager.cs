using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolManager : MonoBehaviour
{
    private static ToolManager _instance;
    public static ToolManager Instance => _instance;
    public string seciliBlok = "yok";
    public int blok1Count, blok2Count, blok3Count;
    [SerializeField] private Button blok1, blok2, blok3;

    void Start()
    {
        _instance = this;
    }

    
    void Update()
    {
        
    }

    public void Blok1()
    {
        seciliBlok = "Blok1";
        ResetButtonAnimations();
        blok1.GetComponent<Animator>().Play("Button Select");
    }
    public void Blok2()
    {
        seciliBlok = "Blok2";
        ResetButtonAnimations();
        blok2.GetComponent<Animator>().Play("Button Select");
    }
    public void Blok3()
    {
        seciliBlok = "Blok3";
        ResetButtonAnimations();
        blok3.GetComponent<Animator>().Play("Button Select");
    }

    void ResetButtonAnimations()
    {
        blok1.GetComponent<Animator>().Play("Idle");
        blok2.GetComponent<Animator>().Play("Idle");
        blok3.GetComponent<Animator>().Play("Idle");
    }
}
