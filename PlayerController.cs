using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //VARIABLES//    


    /////////Variables para el salto del personaje
    //Esto es para la fuerza con la que el player va a saltar
    public float JumpForce;
    //Estamos haciendo referencia al RigidBody2D del player
    private Rigidbody2D Rigidbody;
    //Esta variable es para saber quien es el suelo
    public LayerMask groundMask; 
    //Es para medir la distancia que tiene con el suelo
    public float GroundDistance = 1.5f;
    /////////Animaciones del player
    //estamos haciendo referencia a las animaciones del player
    Animator animator;


    //Es un void que se inicia cuando el juego inicia 
    private void Awake() {
        Rigidbody = GetComponent<Rigidbody2D>();    
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        //Esto es para que cuando apretemos la tecla de space se active la funcion
        if(Input.GetKeyDown(KeyCode.Space)){
            //Estamos llamando a la funcion creada 
            JumpController();
            Debug.Log("SALTO");        
        }
        //
        animator.SetBool("isGround", isTouchingTheGround());    
    




        Debug.DrawRay(this.transform.position, Vector2.down * 1.5f, Color.blue);       
    }


    //Salto
    void JumpController(){
        if(isTouchingTheGround()){
        //Esto es para que el player salte
        Rigidbody.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        }
    }

    //Esto es para ver si el player esta tocando el suelo o no
    bool isTouchingTheGround(){
        //return Physics2D.Raycast(this.transform.position, Vector2.down, 0.2f, groundMask);
        //Esto es una funcion que envia un rayo en el Vector2 dowm, y si tiene el layer groundMask se confirma
        if(Physics2D.Raycast(this.transform.position, Vector2.down, GroundDistance, groundMask)){
            return true;   
            
        }
        else{
            return false;
        }
    }

}
