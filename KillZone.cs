using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{

    private void Awake() {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Esto es para las coliciones de este gameObject
    private void OnTriggerEnter2D(Collider2D collider) {
        //Esto sucedera cuando coliciones con el Player
        if(collider.tag == "Player"){
            //Esto es para llamar al script del player que es PlayerCotroller
            PlayerController player = collider.GetComponent<PlayerController>();
            //Esto es para llamar a la funcion de Die que es para la muerte del player
            player.Die();
            Debug.Log("DIE");
        }
    }
}
