using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador_obstaculos : MonoBehaviour
{
    public Object_pooling pooling_Obstaculos;
    public Transform posicion_instanciacion;
    public float velocidad_instanciacion;
    public float rango_y_instanciacion;
    private void Start()
    {
        IEnumerator courutine_instanciar = Instanciar_();
        StartCoroutine(courutine_instanciar);
    }


    public IEnumerator Instanciar_()
    {
        while (true)
        {
           
            yield return new WaitForSeconds(velocidad_instanciacion);
            //GameObject obstaculo_ = pooling_Obstaculos.Get_obstaculo();
            //obstaculo_.SetActive(true);
           
            float rango = Random.Range(-rango_y_instanciacion, rango_y_instanciacion);
            //obstaculo_.transform.position = new Vector3(posicion_instanciacion.position.x, posicion_instanciacion.position.y + rango, posicion_instanciacion.position.z);
            //obstaculo_.GetComponent<Collider2D>().enabled = true;
        }
    }
}
