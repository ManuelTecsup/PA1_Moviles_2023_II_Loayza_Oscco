using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_pooling : MonoBehaviour
{
    public GameObject prefab;
    public Stack<GameObject> pooling;

    private void Awake()
    {
        pooling = new Stack<GameObject>();
    }
    private void Start()
    {

    }

    public GameObject Get_Object()
    {
        if (pooling.Count == 0)
        {
            GameObject objeto_instanciado = Instantiate(prefab);
            objeto_instanciado.GetComponent<Op_object>().Set_object_pooling(this);

            return objeto_instanciado;
        }
        else
        {
            GameObject bala_retornada = pooling.Pop();

            return bala_retornada;
        }

    }
    public void Retornar_objeto(GameObject objeto_retornado)
    {
        objeto_retornado.GetComponent<Collider2D>().enabled = false;
        objeto_retornado.SetActive(false);

        pooling.Push(objeto_retornado);

        Debug.Log(pooling.Count);
    }
}
