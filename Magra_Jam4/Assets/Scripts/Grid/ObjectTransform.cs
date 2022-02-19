using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransform : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButton(1))
        {
            Destroy(gameObject);
        }
    }
}
