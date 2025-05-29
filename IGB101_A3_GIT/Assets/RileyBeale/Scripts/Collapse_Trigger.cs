using UnityEngine;

public class Collapse_Trigger : MonoBehaviour
{
    public GameObject ceiling;
    AudioSource rubbleCrash;
    Animation anim;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = ceiling.GetComponent<Animation>();
        rubbleCrash = ceiling.GetComponentInChildren<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Collapse_Trigger")
        {
            anim.Play();
            rubbleCrash.Play();
            Destroy(collider.gameObject);
        }
    }
}
