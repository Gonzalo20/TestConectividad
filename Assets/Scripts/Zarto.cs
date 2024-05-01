using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zarto : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public float Horizontal; 
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * JumpForce);
            //aaaaaaaaaaaa
        }
    }
}
