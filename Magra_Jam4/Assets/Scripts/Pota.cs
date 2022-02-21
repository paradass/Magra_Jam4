using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pota : MonoBehaviour
{
    static private Pota _instance;
    public static Pota Instance => _instance;
    public string suankiSahne;
    [SerializeField] private string gecilecekSahne;
    void Start()
    {
        _instance = this;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            SceneManager.LoadScene(gecilecekSahne);
        }
    }
}
