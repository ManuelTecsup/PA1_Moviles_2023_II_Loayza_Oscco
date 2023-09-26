using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara_ : MonoBehaviour
{
    public Transform objeto_a_seguir;
    private float distancia_x;
    private void Start()
    {
        distancia_x = objeto_a_seguir.position.x - transform.position.x;
    }
    private void Update()
    {
        transform.position =new Vector3( objeto_a_seguir.position.x - distancia_x,transform.position.y,transform.position.z);
    }
}
