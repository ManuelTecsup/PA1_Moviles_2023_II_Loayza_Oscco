using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear_object_op : MonoBehaviour
{
    public int id_object_pooling;
    public Transform position;
    
    public void Crear()
    {
        GameObject objeto= Lista_objetcs_pooling.instance[id_object_pooling].Get_Object();
        objeto.transform.position = position.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colision");
        if (collision.tag == "Player")
        {
            Crear();
        }
        
    }

}
