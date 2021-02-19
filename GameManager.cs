using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Esto esta fuera del class GameManager para que podamos llamarlo desde fuera del script con mas facilidad

public enum GameState{
//Esto es un estado cada una de estos estados representa un estado en el juego
    menu,
    inGame,
    gameOver
}


public class GameManager : MonoBehaviour
{
    //Esta es una variable de tipo GameState que fue lo que creamos anteriormente 
    //currentGameState esto es el estado del juego actual
    //GameState.menu es para que inicie en el valor menu
    public GameState currentGameState = GameState.menu;

    //VARIABLE//

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){

    }
    public void GameOver(){

    }
    public void BackMenu(){

    }


    // Esto es para cambiar el estado del juego
    //newGameState es la variable para el nuevo estado del juego
    private void SetGameState(GameState newGameState){
        if(newGameState == GameState.menu){
            //COLOCAR LA LOGICA DEL MENU
        }
        else if(newGameState == GameState.inGame){
            //HAY QUE PREPARAR LA ESCENA PARA JUGAR    
        }
        else if(newGameState == GameState.gameOver){
            //PREPARAR EL JUEGO PARA EL GAMEOVER
        }

        this.currentGameState = newGameState;
    }
}
