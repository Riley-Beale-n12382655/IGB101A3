using UnityEngine;

public class Pickup : MonoBehaviour
{

    GameManager gameManager;
    AudioSource partyHorn;
    public GameObject confetti;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        partyHorn = GetComponent<AudioSource>();


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
            partyHorn.Play();
            Destroy(gameObject);
        }
    }
}
