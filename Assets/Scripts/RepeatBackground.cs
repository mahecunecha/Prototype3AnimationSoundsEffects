using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos; // definimos una variable que va a guardar la posicion x,y,z
    private float repeatWidht;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;// asignamos a startPos el valor de la pocision inicial 
        repeatWidht = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidht)
        {
            transform.position = startPos;
        }
    }
}