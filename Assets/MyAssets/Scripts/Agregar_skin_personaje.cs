using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agregar_skin_personaje : MonoBehaviour
{
    public Lista_personajes lista_Personajes;
    public Transform pos_instanciacion_skin;
    private void Start()
    {
        Instantiate(lista_Personajes.Get_personaje_escogido(), pos_instanciacion_skin);
    }
}
