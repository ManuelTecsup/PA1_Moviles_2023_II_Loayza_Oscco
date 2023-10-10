using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_global_manager : MonoBehaviour
{
    
    

    public void Load_Scene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void Load_async_scene(string sceneName)
    {


        IEnumerator courutine_load_async_scene = Courutine_Load_Async_Scene(sceneName);
        StartCoroutine(courutine_load_async_scene);

    }
    
    private void Desactivar_objetos_escena(string sceneName)
    {
        for (int i = 0; i < sceneName.Length; i++)
        {
            GameObject[] lista = SceneManager.GetSceneByName(sceneName).GetRootGameObjects();
            foreach (GameObject item in lista)
            {
                item.SetActive(false);
            }
        }
      
    }
    private void Activar_objetos_escena(string sceneName)
    {
        for (int i = 0; i < sceneName.Length; i++)
        {
            GameObject[] lista = SceneManager.GetSceneByName(sceneName).GetRootGameObjects();
            foreach (GameObject item in lista)
            {
                item.SetActive(true);
            }
        }

    }

    private IEnumerator Courutine_Load_Async_Scene(string sceneName)
    {
        
        
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName,LoadSceneMode.Additive);
       

        while (!asyncLoad.isDone)
        {
            
            yield return null;
        }
        Desactivar_objetos_escena(sceneName);
    }
    public void Mostrar_Scene(string sceneName)
    {
        Activar_objetos_escena(sceneName);
    }
    public void Ocultar_Scene(string sceneName)
    {
        Desactivar_objetos_escena(sceneName);
    }
}
