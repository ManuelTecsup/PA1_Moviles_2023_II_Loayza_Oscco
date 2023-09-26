using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Op_object : MonoBehaviour
{
    Object_pooling object_Pooling;
    

    public void Set_object_pooling(Object_pooling object_Pooling_)
    {
        object_Pooling = object_Pooling_;
    }

    public void Destruir_()
    {
        object_Pooling.Retornar_objeto(gameObject);
    }
}
