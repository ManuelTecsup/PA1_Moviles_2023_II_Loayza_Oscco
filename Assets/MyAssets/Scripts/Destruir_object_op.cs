using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir_object_op : MonoBehaviour
{
    public Op_object op_Object;
    

    public void Destruir()
    {
        op_Object.Destruir_();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colision");
        if (collision.tag == "Player")
        {
            Destruir();
        }
    }
}
