using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitchMaxP : MonoBehaviour{

    GameManagerMaxP gameManager;
    public string nextLevel;

    //Start is called before first fram update
    void Start(){
        gameManager = GameObject.FindGameObjectWithTag("GameManagerMaxP").GetComponent<GameManagerMaxP>();
    }
    
    private void OnTriggerEnter(Collider otherObject){
        if(otherObject.transform.tag == "Player"){

            if(gameManager.levelComplete){
            SceneManager.LoadScene(nextLevel);
            }
        }
    }
}