using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float velocidad_x;
    public float velocidad_y;

    private void Update()
    {
        rigidbody2D.velocity = new Vector2(velocidad_x,rigidbody2D.velocity.y);

        if (Input.GetMouseButton(0))
        {
            rigidbody2D.velocity = new Vector2(velocidad_x, velocidad_y);
        }
        
    }

}
