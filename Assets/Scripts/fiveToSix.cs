using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fiveToSix : MonoBehaviour
{
    public GameObject student;
    public GameObject staff;
    public Animation stuAni;
    public Animation staAni;
    public GameObject mainCamera;
    public GameObject fiveToSixButton;

    // Start is called before the first frame update
    void Start()
    {
        stuAni = student.GetComponent<Animation>();
        stuAni.Play();
        staAni = staff.GetComponent<Animation>();
        staAni.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fiveToSixPressed()
    {
        fiveToSixButton.SetActive(false);
        staff.SetActive(false);

        stuAni.CrossFade("idle_01");
        stuAni.Play();

        mainCamera.transform.position = new Vector3(-4072, 153, -326);
        mainCamera.transform.eulerAngles = new Vector3(0, -60, 0);
    }
}
