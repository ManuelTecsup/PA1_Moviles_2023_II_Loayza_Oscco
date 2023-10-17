using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash_screen_scene : MonoBehaviour
{
    public RectTransform barra_splash_screen;
    public float valor_final;
    public float velocidad;
   
    void Start()
    {
        IEnumerator coroutine_barra = coroutine_barra_de_carga();
        StartCoroutine(coroutine_barra);
    }

   
    private IEnumerator coroutine_barra_de_carga()
    {
        Scene_global_manager.instance.Load_async_scene("Menu");
        while (barra_splash_screen.localScale.x<=valor_final)
        {
            barra_splash_screen.localScale = new Vector3(barra_splash_screen.localScale.x + velocidad, barra_splash_screen.localScale.y, barra_splash_screen.localScale.z);
            yield return null;
        }
        while (Scene_global_manager.instance.Scene_is_loaded("Menu") == false)
        {
            Debug.Log("Escena cargando");
        }
        Debug.Log("Menu mostrando");
        Scene_global_manager.instance.Mostrar_Scene("Menu");
        Scene_global_manager.instance.Unload_scene_Async("Splash_screen");
        
    }
}
