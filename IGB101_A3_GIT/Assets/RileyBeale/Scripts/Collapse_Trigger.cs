using UnityEngine;

public class Collapse_Trigger : MonoBehaviour
{
    public GameObject ceiling;
    Animation anim;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = ceiling.GetComponent<Animation>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Collapse_Trigger")
        {
            anim.Play();
            Destroy(collider.gameObject);
        }
    }
}
