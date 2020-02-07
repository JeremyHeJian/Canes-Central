using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oneToTwo : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject student;
    public Animation anim;
    public GameObject oneToTwoButton;
    public GameObject twoToThreeButton;
    public GameObject registerDia;

    // Start is called before the first frame update
    void Start()
    {
        anim = student.GetComponent<Animation>();
        anim.Play();
        registerDia.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void oneToTwoPressed()
    {
        oneToTwoButton.SetActive(false);
        twoToThreeButton.SetActive(true);

        mainCamera.transform.position = new Vector3(-3562, 174, -501);
        mainCamera.transform.eulerAngles = new Vector3(0, 180, 0);
        mainCamera.SetActive(true);

        student.transform.position = new Vector3(-3597, 1.3f, -690);
        student.transform.eulerAngles = new Vector3(0, 180, 0);

        anim.Play();
        anim.CrossFade("reachout_00");

        registerDia.SetActive(true);
    }
}
