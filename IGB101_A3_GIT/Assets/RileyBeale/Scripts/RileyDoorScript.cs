using Unity.VisualScripting;
using UnityEngine;
public class RileyDoorScript : MonoBehaviour
{
    public GameManager manager;
    public GameObject player;
    public DoorController doorController;
    private bool hasScripted;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.levelComplete == true && hasScripted == false) 
        {   
            doorController = this.AddComponent<DoorController>();
            doorController.PlayerPos = player.transform;
            hasScripted = true;
        }
    }
}
