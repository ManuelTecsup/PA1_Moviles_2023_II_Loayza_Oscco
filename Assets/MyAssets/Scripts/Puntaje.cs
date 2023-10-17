using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Puntaje", menuName = "ScriptableObjects/Puntaje")]
public class Puntaje : ScriptableObject
{
    public int puntaje;
    

    public void Aumentar_monedas(int value)
    {
        puntaje = puntaje + value;
    }
}
