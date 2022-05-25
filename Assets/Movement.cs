using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;


    Vector2 movement;
    // Start is called before the first frame update



    // Update is called once per frame
    void Update()
    {
        MovementInput();
    }
    private void FixedUpdate()
    {
        rb.velocity = movement*moveSpeed;
    }

    void MovementInput ()
    {
        float mx = Input.GetAxisRaw("Horizontal");
        float my = Input.GetAxisRaw("Vertical");

        movement = new Vector2(mx, my).normalized;
    }
}
