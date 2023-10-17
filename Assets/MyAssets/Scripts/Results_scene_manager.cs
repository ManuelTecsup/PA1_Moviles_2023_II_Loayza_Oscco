using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Results_scene_manager : MonoBehaviour
{
    public void boton_atras()
    {
        Scene_global_manager.instance.Load_Scene("Menu"); 
    }
}
