using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studentStart : MonoBehaviour
{
    public Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        anim.Stop();
        transform.position = new Vector3(-4902, 1.3f, -455);
        transform.eulerAngles = new Vector3(0, 90, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
