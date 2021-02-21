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
    //Esto es para que no haya cruces entre script que este script sea unico y los script nose contraduscan
    //GameManager estamos haciendo referencia al script actual
    public static GameManager sharesInstance;


    //VARIABLE//

    void Awake() {
        //Esto es para que el primero que cree este sharesInstance, por eso comprueba si alguien lo cambio anteriormente
        if(sharesInstance == null){
            //Esto es para aclarar que este script es la instancia compartida
            sharesInstance = this;    
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Home)){
            Debug.Log("StartGame");
            StartGame();
        }
        else if(Input.GetKeyDown(KeyCode.Escape)){
            Debug.Log("Menu");
            BackMenu();
        }
    }

    //Esto es el inicio del juego
    public void StartGame(){
        //Esto es para que inicie el juego
        SetGameState(GameState.inGame);
    }
    public void GameOver(){
        SetGameState(GameState.gameOver);
    }
    public void BackMenu(){
        SetGameState(GameState.menu);
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
