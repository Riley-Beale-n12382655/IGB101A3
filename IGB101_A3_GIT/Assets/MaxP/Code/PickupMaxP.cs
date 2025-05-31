using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupMaxP : MonoBehaviour{

    GameManagerMaxP gameManager;

    //Start is called before first frame update
    void Start(){
        gameManager = GameObject.FindGameObjectWithTag("GameManagerMaxP").GetComponent<GameManagerMaxP>();
    }

    private void OnTriggerEnter (Collider otherObject){
        if(otherObject.transform.tag == "Player"){
            gameManager.currentPickups += 1;
            Destroy(this.gameObject);
        }
    }
}  
