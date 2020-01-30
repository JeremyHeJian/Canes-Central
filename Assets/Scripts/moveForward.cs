using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    public GameObject stu;
    public float moveSpeed = 100.0f;
    public Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        MoveForward();
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
    }

    void MoveForward()
    {
        if (stu.transform.position.x < -4050)
        {
            stu.transform.position += stu.transform.forward * Time.deltaTime * moveSpeed;
        }
        else
        {
            Debug.Log(stu.transform.position);
            anim.Stop();
        }
        
    }
}
