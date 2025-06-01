
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animation anim;
    public Transform PlayerPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("f") && (Vector3.Distance(this.transform.position, PlayerPos.position) < 5f))
        {
            anim.Play();
        }
    }
}
