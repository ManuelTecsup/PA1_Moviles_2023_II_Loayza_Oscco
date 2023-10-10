using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Lista_max_puntajes", menuName = "ScriptableObjects/Lista_max_puntajes")]
public class Lista_max_puntajes : ScriptableObject
{
    public List<int> maximos_puntajes;

    public void Enviar_puntaje(int puntaje)
    {
        if (puntaje > maximos_puntajes[0])
        {
            maximos_puntajes[0] = puntaje;
        }

        for (int i = 1; i < maximos_puntajes.Count; i++)
        {
            if (maximos_puntajes[i-1] > maximos_puntajes[i])
            {
                int copia = maximos_puntajes[i];
                maximos_puntajes[i] = maximos_puntajes[i-1];
                maximos_puntajes[i-1] = copia;
            }
        }
    }

   

}
