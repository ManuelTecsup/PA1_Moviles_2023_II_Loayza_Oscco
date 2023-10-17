using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Lista_personajes", menuName = "ScriptableObjects/Lista_personajes")]
public class Lista_personajes : ScriptableObject
{

    public List<personaje> personajes;
    public int id_personaje_escogido;

    public void Set_personaje_escogido_id(int id)
    {
        id_personaje_escogido = id;
    }
    public personaje Get_personaje_escogido()
    {
        return personajes[id_personaje_escogido]; 
    }
    public personaje Get_personaje_by_id(int id)
    {
        return personajes[id];
    }
}


[System.Serializable]
public class personaje {
    
    public string nombre;
    public GameObject prefab;
    public bool desbloqueado;

    public void Desbloquear()
    {
        desbloqueado = true;
    }

}