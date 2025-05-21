using UnityEngine;

public class Pickup : MonoBehaviour
{

    GameManager gameManager;
    public GameObject confetti;
    AudioSource horn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider otherObject)
    {
        if(otherObject.transform.tag == "Player")
        {
            gameManager.currentPickups += 1;
            Instantiate(confetti, transform.position, Quaternion.Euler(-90, 0, 0));
            GetComponent<AudioSource>().Play(0);
            Destroy(gameObject);
        }
    }
}
