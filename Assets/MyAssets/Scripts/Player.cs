using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Lista_max_puntajes lista_Max_Puntajes;
    public Rigidbody2D rigidbody2D;
    public float velocidad_x;
    public float velocidad_y;
    public Puntaje puntaje;
    public int valor_monedas;
    public int valor_tiempo_score;
    private void Start()
    {
        puntaje.puntaje = 0;
    }
    private void Update()
    {
        rigidbody2D.velocity = new Vector2(velocidad_x,rigidbody2D.velocity.y);

        if (Input.GetMouseButton(0))
        {
            rigidbody2D.velocity = new Vector2(velocidad_x, velocidad_y);
        }
        
    }
    private void FixedUpdate()
    {
        puntaje.Aumentar_monedas(valor_tiempo_score);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Moneda")
        {
            puntaje.Aumentar_monedas(valor_monedas);
        }
        else if (collision.tag == "Enemigo")
        {
            lista_Max_Puntajes.Enviar_puntaje(puntaje.puntaje);
            Scene_global_manager.instance.Mostrar_Scene("Results");
            Scene_global_manager.instance.Ocultar_Scene("Game_");
            
        }
    }

}
