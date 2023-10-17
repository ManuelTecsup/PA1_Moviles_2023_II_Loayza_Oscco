using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class seleccion_personaje_scene_manager : MonoBehaviour
{
    public Data_game data_Game;
    public TextMeshProUGUI moneda;
    
    private void Start()
    {
        Actualizar_UI();
    }
    public void Actualizar_UI()
    {
        moneda.text = data_Game.monedas + "";
    }
    public void boton_play()
    {
        Scene_global_manager.instance.Load_async_scene("Game_");
        Scene_global_manager.instance.Load_async_scene("Results");
        Scene_global_manager.instance.Mostrar_Scene("Game_");
        Scene_global_manager.instance.Ocultar_Scene("Seleccion_personaje");
        Scene_global_manager.instance.Unload_scene_Async("Seleccion_personaje");
    }
}
