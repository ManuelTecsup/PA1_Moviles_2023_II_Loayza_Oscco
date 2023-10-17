using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seleccion_personaje_scene_manager : MonoBehaviour
{
    public void boton_play()
    {
        Scene_global_manager.instance.Load_async_scene("Game_");
        Scene_global_manager.instance.Load_async_scene("Results");
        Scene_global_manager.instance.Mostrar_Scene("Game_");
        Scene_global_manager.instance.Ocultar_Scene("Seleccion_personaje");
        Scene_global_manager.instance.Unload_scene_Async("Seleccion_personaje");
    }
}
