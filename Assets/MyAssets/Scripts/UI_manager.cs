using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UI_manager : MonoBehaviour
{
    public TextMeshProUGUI text_puntaje;
    public Puntaje puntaje;
    private void Update()
    {
        Actualizar_UI();
    }
    private void Actualizar_UI()
    {
        text_puntaje.text = puntaje.puntaje+"";
    }
}
