using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_coleccionable : MonoBehaviour
{
    public float distancia_movimiento_y;
    public float velocidad;

    private void Start()
    {
       
    }
    private void Update()
    {
        
    }
    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x + velocidad, transform.position.y + velocidad, transform.position.z);
    }

}
