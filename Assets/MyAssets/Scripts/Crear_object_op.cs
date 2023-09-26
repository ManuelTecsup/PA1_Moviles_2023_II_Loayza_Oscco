using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear_object_op : MonoBehaviour
{
    Object_pooling object_Pooling;
    public Transform position;
    
    public void Crear()
    {
        GameObject objeto= object_Pooling.Get_Object();
        objeto.transform.position = position.position;
    }
   
}
