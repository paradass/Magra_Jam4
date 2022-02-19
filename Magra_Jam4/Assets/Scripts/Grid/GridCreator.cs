using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCreator : MonoBehaviour
{
    [SerializeField] private int xTekrar, yTekrar;
    [SerializeField] private float xBosluk, yBosluk,kalinanX,kalinanY;
    [SerializeField] private GameObject gridObject;
    void Start()
    {
        Olustur();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Olustur()
    {
        for(int i = 0; i < yTekrar; i++)
        {
            kalinanY = transform.position.y - i*yBosluk;
            for(int a = 0; a < xTekrar; a++)
            {
                kalinanX = transform.position.x + a * xBosluk;
                GameObject grid =  Instantiate(gridObject, new Vector3(kalinanX, kalinanY, 0), Quaternion.identity);
                grid.transform.parent = transform;
            }
        }
    }
}
