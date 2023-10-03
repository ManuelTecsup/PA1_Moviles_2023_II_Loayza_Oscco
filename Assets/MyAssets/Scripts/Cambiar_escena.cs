using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiar_escena : MonoBehaviour
{
    public string escenario;
    
    public void Cambiar()
    {
        SceneManager.LoadScene(escenario);
    }
}
