using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformacion : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject modificador;
    public GameObject nodo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float prueva = nodo.transform.position.x;
        if (modificador.transform.position.x >= nodo.transform.position.x){
            transform.position = Vector3.MoveTowards(new Vector3(modificador.transform.position.x,0f,0f),new Vector3(nodo.transform.position.x,0f,0f), 0.001f);
        }
        transform.
    }
}
