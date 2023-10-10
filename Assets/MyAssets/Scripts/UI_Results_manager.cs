using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UI_Results_manager : MonoBehaviour
{
    public Lista_max_puntajes lista_Max_Puntajes;
    public List<TextMeshProUGUI> lista_texts_max_puntajes;

    private void Start()
    {
        for (int i = 0; i < lista_texts_max_puntajes.Count; i++)
        {
            lista_texts_max_puntajes[i].text = "" + lista_Max_Puntajes.maximos_puntajes[i];
        }   
    }

}
