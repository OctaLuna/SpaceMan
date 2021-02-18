using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //VARIABLES//    

    private bool isGround = false;
    /////////Variables para el salto del personaje
    //Esto es para la fuerza con la que el player va a saltar
    public float JumpForce;
    //Estamos haciendo referencia al RigidBody2D del player
    private Rigidbody2D Rigidbody;
    //Esta variable es para saber quien es el suelo
    public LayerMask groundMask; 


    //Es un void que se inicia cuando el juego inicia 
    private void Awake() {
        Rigidbody = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        if(isGround == true){
            //Esto es para que cuando apretemos la tecla de space se active la funcion
            if(Input.GetKeyDown(KeyCode.Space)){
                //Estamos llamando a la funcion creada 
                JumpController();
                isGround = false;
                Debug.Log("Salto");
            }
        }
                
    }


    //Salto
    void JumpController(){
        //Esto es para que el player salte
        Rigidbody.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
    }

    //Esto es para ver si el player esta tocando el suelo o no
    bool isTouchingTheGround(){
        return Physics2D.Raycast(this.transform.position, Vector2.down, 0.2f, groundMask);
        //if(Physics2D.Raycast(this.transform.position, Vector2.down, 0.2f, groundMask)){
                             
        //}
        //else{

        //}
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Ground")){
            isGround = true;
        }
    }

}
