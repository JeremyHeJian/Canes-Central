using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScene : MonoBehaviour
{
    public float moveSpeed = 100.0f;
    public Animation anim;
    public GameObject student;
    public bool startScenePressed;
    public GameObject oneToTwoButton;
    public GameObject startButton;
    public GameObject twoToThreeButton;
    public GameObject nameOrder;
    public GameObject threeToFourButton;
    public GameObject registerDia;

    // Start is called before the first frame update
    void Start()
    {
        oneToTwoButton.SetActive(false);
        twoToThreeButton.SetActive(false);
        threeToFourButton.SetActive(false);
        nameOrder.SetActive(false);
        registerDia.SetActive(false);
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
