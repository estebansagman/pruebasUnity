using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tamaño : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame

    public float divicion = 1000;
    void Update()
    {
      
      Vector3 mouspos = Input.mousePosition;

        Debug.Log(mouspos.x/divicion + " - " + mouspos.y/divicion);

        transform.position = Vector3.MoveTowards(transform.position,mouspos/divicion, 0.05f);
    }       
}
