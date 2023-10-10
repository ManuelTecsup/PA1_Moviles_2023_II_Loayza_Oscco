using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Lista_personajes", menuName = "ScriptableObjects/Lista_personajes")]
public class Lista_personajes : ScriptableObject
{

    public List<GameObject> personajes;
    public int id_personaje_escogido;

    public void Set_personaje_escogido_id(int id)
    {
        id_personaje_escogido = id;
    }
    public GameObject Get_personaje_escogido()
    {
        return personajes[id_personaje_escogido]; 
    }
}
