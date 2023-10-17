using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data_game", menuName = "ScriptableObjects/Data_game")]
public class Data_game : ScriptableObject
{

    public int monedas;

    public void Aumentar_monedas(int value)
    {
        monedas = monedas + value;
    }

    public void Quitar_monedas(int value)
    {
        monedas = monedas - value;
    }
    public int Get_monedas_value()
    {
        return monedas;
    }
    
}
