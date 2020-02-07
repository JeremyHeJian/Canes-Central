using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fourToFive : MonoBehaviour
{
    public GameObject student;
    public GameObject staff;
    public Animation stuAni;
    public Animation staAni;
    public GameObject fourToFiveButton;
    public GameObject nameDia;
    public GameObject mainCamera;
    public GameObject fiveToSixButton;

    // Start is called before the first frame update
    void Start()
    {
        stuAni = student.GetComponent<Animation>();
        stuAni.Play();
        staAni = staff.GetComponent<Animation>();
        staAni.Play();

        staff.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fourToFivePressed()
    {
        fourToFiveButton.SetActive(false);
        fiveToSixButton.SetActive(true);
        nameDia.SetActive(false);

        staff.transform.position = new Vector3(-3978, 1.3f, -381);
        staff.transform.eulerAngles = new Vector3(0, -60, 0);
        staff.SetActive(true);

        staAni.Play();
        staAni.CrossFade("greet_01");

        student.transform.position = new Vector3(-4131, 1.3f, -291);
        student.transform.eulerAngles = new Vector3(0, 120, 0);

        stuAni.Play();
        stuAni.CrossFade("greet_01");

        mainCamera.transform.position = new Vector3(-3829, 175, -370);
        mainCamera.transform.eulerAngles = new Vector3(0, -60, 0); 
    }
}
