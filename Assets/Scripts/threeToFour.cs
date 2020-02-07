using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class threeToFour : MonoBehaviour
{
    public GameObject student;
    public GameObject threeToFourButton;
    public Animation anim;
    public GameObject mainCamera;
    public GameObject nameDia;
    public GameObject fourToFiveButton;

    // Start is called before the first frame update
    void Start()
    {
        anim = student.GetComponent<Animation>();
        anim.Play();
        fourToFiveButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void threeToFourPressed()
    {
        nameDia.SetActive(false);

        threeToFourButton.SetActive(false);
        fourToFiveButton.SetActive(true);

        mainCamera.transform.position = new Vector3(-4003, 174, -446);
        mainCamera.transform.eulerAngles = new Vector3(0, -30, 0);

        student.transform.position = new Vector3(-4167, 1.3f, -268);
        student.transform.eulerAngles = new Vector3(0, 90, 0);

        anim.Play();
        anim.CrossFade("sit_00");
    }
}
