using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScene : MonoBehaviour
{
    public float moveSpeed = 100.0f;
    public Animation anim;
    public GameObject student;
    public GameObject staff;
    public bool startScenePressed;
    public GameObject oneToTwoButton;
    public GameObject startButton;
    public GameObject twoToThreeButton;
    public GameObject nameOrder;
    public GameObject threeToFourButton;
    public GameObject registerDia;
    public GameObject nameDia;
    public GameObject fourToFiveButton;
    public GameObject fiveToSixButton;

    // Start is called before the first frame update
    void Start()
    {
        staff.SetActive(false);
        oneToTwoButton.SetActive(false);
        twoToThreeButton.SetActive(false);
        threeToFourButton.SetActive(false);
        nameOrder.SetActive(false);
        registerDia.SetActive(false);
        nameDia.SetActive(false);
        fourToFiveButton.SetActive(false);
        fiveToSixButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(startScenePressed == true)
        {
            SceneStarted();
            
        }
    }

    public void StartPressed()
    {
        anim.Play();
        anim.CrossFade("walk_00");

        oneToTwoButton.SetActive(true);
        twoToThreeButton.SetActive(false);
        threeToFourButton.SetActive(false);
        startButton.SetActive(false);
        registerDia.SetActive(false);
        nameDia.SetActive(false);

        startScenePressed = true;
    }

    public void SceneStarted()
    {
        anim = student.GetComponent<Animation>();

        if (student.transform.position.x < -4027)
        {
            student.transform.position += student.transform.forward * Time.deltaTime * moveSpeed;
        }
        else
        {
            Debug.Log(student.transform.position);
            //anim.Stop();
            startScenePressed = false;
        }

    }


}
