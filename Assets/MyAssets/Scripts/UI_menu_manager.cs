using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UI_menu_manager : MonoBehaviour
{

    public TextMeshProUGUI text_max_puntaje;
    public Lista_max_puntajes lista_Max_Puntajes;

    private void Start()
    {
        text_max_puntaje.text = "" + lista_Max_Puntajes.maximos_puntajes[lista_Max_Puntajes.maximos_puntajes.Count-1];
    }

    public void Boton_play()
    {
        Scene_global_manager.instance.Load_Scene("Seleccion_personaje");
    }
    public void Boton_configuracion()
    {
        Scene_global_manager.instance.Load_Scene("Seleccion_personaje");
    }
}
