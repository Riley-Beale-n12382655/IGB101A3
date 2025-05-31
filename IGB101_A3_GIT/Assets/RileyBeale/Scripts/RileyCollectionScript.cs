using UnityEngine;

public class RileyCollectionScript : MonoBehaviour
{
    AudioSource partyHorn;
    public GameObject confetti;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        partyHorn = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.transform.tag == "Player")
        {
            Instantiate(confetti, transform.position, Quaternion.Euler(-90, 0, 0));
            partyHorn.Play();
        }
    }
}
