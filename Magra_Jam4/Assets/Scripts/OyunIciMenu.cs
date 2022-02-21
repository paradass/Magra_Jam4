using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunIciMenu : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void DurdurBtn()
    {
        Time.timeScale = 0;
        menu.SetActive(true);
    }

    public void DevamEtBtn()
    {
        Time.timeScale = 1;
        menu.SetActive(false);
    }

    public void ResetBtn()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(Pota.Instance.suankiSahne);
    }

    public void MenuBtn()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
