using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_global_manager : MonoBehaviour
{
    public static Scene_global_manager instance;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (instance == null)
        {

            instance = this;
        }
    }

    public bool Scene_is_loaded(string sceneName)
    {
        return SceneManager.GetSceneByName(sceneName).isLoaded;
    }
    public void Load_Scene(string sceneName)
    {
       
        SceneManager.LoadScene(sceneName);
    }
    public void Unload_scene_Async(string sceneName)
    {
        SceneManager.UnloadSceneAsync(sceneName);
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
        IEnumerator enumerator = Coroutine_Mostrar_scene(sceneName);
        StartCoroutine(enumerator);
    }
    
    public void Ocultar_Scene(string sceneName)
    {
        IEnumerator enumerator = Coroutine_Ocultar_scene(sceneName);
        StartCoroutine(enumerator);
    }
    private IEnumerator Coroutine_Mostrar_scene(string sceneName)
    {
        while (SceneManager.GetSceneByName(sceneName).isLoaded == false)
        {
            yield return null;
        }
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
        Activar_objetos_escena(sceneName);
        yield return null;
    }
    private IEnumerator Coroutine_Ocultar_scene(string sceneName)
    {
        while (SceneManager.GetSceneByName(sceneName).isLoaded == false)
        {
            yield return null;
        }
        Desactivar_objetos_escena(sceneName);
    }
}
