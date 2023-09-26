using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear_object_op : MonoBehaviour
{
    public Op_object op_Object;
    public Transform position;
    
    public void Crear()
    {
        GameObject objeto= op_Object.GetObject_Pooling().Get_Object();
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
