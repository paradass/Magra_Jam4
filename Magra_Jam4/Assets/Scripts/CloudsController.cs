using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsController : MonoBehaviour
{

    public GameObject[] Clouds;
    public float[] CloudSpeed;

    private int des;

    public Vector2[] CloudAims;
    public GameObject[] CloudDes;
    public float[] CloudSpeeds;

    void Start()
    {
        CloudsStarting();
    }

    void Update()
    {
        CloudMovement();
    }

    void CloudsStarting()
    {
        CloudAims = new Vector2[Clouds.Length];
        for (int i = 0; i < Clouds.Length; i++)
        {
            des = Random.Range(0, CloudDes.Length);
            CloudAims[i] = new Vector2(CloudDes[des].transform.position.x, CloudDes[des].transform.position.y);
        }
        CloudSpeeds = new float[Clouds.Length];
        for (int j = 0; j < Clouds.Length; j++)
        {
            CloudSpeeds[j] = CloudSpeed[Random.Range(0, CloudSpeed.Length)];
        }
    }
    void CloudMovement()
    {
        for (int k = 0; k < Clouds.Length; k++)
        {
            Clouds[k].transform.position = Vector2.MoveTowards(Clouds[k].transform.position, CloudAims[k], CloudSpeeds[k]);
            if (Clouds[k].transform.position.x == CloudAims[k].x && Clouds[k].transform.position.y == CloudAims[k].y) 
            {
                des = Random.Range(0, CloudDes.Length);
                CloudAims[k] = new Vector2(CloudDes[des].transform.position.x,CloudDes[des].transform.position.y);

            }
        }
    }
}
