using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //VARIABLES//    
    //
    private bool isGround  = true;
    //Esto es para la fuerza con la que el player va a saltar
    public float JumpForce = 20f;
    //Estamos haciendo referencia al RigidBody2D del player
    private Rigidbody2D Rigidbody;




    private void Awake() {
        Rigidbody = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        
        if(Input.GetKey(KeyCode.Space)){
            Rigidbody.AddForce(Vector2.up * JumpForce);
        }
                
    }


    void JumpController(){

    }
}
