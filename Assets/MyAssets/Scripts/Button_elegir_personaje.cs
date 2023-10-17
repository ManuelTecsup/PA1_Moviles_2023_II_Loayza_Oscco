using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Button_elegir_personaje : MonoBehaviour
{
    public Lista_personajes lista_Personajes;
    public Data_game data_Game;

    public int id_personaje;
    public int precio;
    public bool desbloqueado;
    public TextMeshProUGUI text_precio;
    public GameObject candado;
    
    // Start is called before the first frame update
    void Start()
    {
        text_precio.text = precio + "";
        if (precio == 0)
        {
            desbloqueado =true;
        }
        if (lista_Personajes.Get_personaje_by_id(id_personaje).desbloqueado == true)
        {
            desbloqueado = true;
        }
        if (desbloqueado == true)
        {
            candado.SetActive(false);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void On_click_personaje()
    {
        lista_Personajes.Set_personaje_escogido_id(id_personaje);
    }
    
    public void On_click_Comprar()
    {
        if (precio <= data_Game.Get_monedas_value())
        {
            data_Game.Quitar_monedas(precio);
            lista_Personajes.Get_personaje_by_id(id_personaje).Desbloquear();
            desbloqueado = true;
            candado.SetActive(false);

        }
    }
}
