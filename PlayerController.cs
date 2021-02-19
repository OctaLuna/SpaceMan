using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //VARIABLES//    


    /////////Salto///////////
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
    /////////Movimiento/////////
    //Esto es para la velocidad del movimiento
    public float SpeedMovement;

    SpriteRenderer SpriteRenderer;


    //Es un void que se inicia cuando el juego inicia 
    private void Awake() {
        Rigidbody = GetComponent<Rigidbody2D>();    
        animator = GetComponent<Animator>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    void Update()
    {
        movement();
        Jump();
    }


  
  
  
  
  
  
  
    /////////////////FUNCIONES/////////////////
  
    
    //////MOVIMIENTO//////
    void movement(){
        ////MOVIMIENTO////
        //esto es para que el personaje se mueva
        Rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * SpeedMovement, Rigidbody.velocity.y);


        //Esto es para que las animacion del player//
        //0 es quieto, +1 es derecha y -1 es izquierda
        //esto es cuando se queda quieto
        if(Input.GetAxis("Horizontal") == 0){
            //esto es para las animaciones de movimiento
            animator.SetBool("isWalking", false);
        }
        else if(Input.GetAxis("Horizontal") > 0){
            animator.SetBool("isWalking", true);
            //Esto es para que el sprite del player se de la vuelta cuando va izquierda que es el siguiente else if
            SpriteRenderer.flipX = false;
        }
        else if(Input.GetAxis("Horizontal") < 0){
            animator.SetBool("isWalking", true);
            SpriteRenderer.flipX = true;
        }
    }


    //////SALTO//////
    //Salto
    void Jump(){
        ////SALTO////
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
