using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twoToThree : MonoBehaviour
{
    public GameObject twoToThreeButton;
    public GameObject oneToTwoButton;
    public GameObject nameOrder;
    public Animation anim;
    public GameObject student;
    public GameObject threeToFourButton;
    public GameObject registerDia;
    public GameObject nameDia;

    // Start is called before the first frame update
    void Start()
    {
        oneToTwoButton.SetActive(false);
        anim = student.GetComponent<Animation>();
        anim.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void twoToThreePressed()
    {
        anim.CrossFade("idle_00");
        anim.Play();

        registerDia.SetActive(false);

        twoToThreeButton.SetActive(false);
        threeToFourButton.SetActive(true);

        nameOrder.SetActive(true);

        nameDia.SetActive(true);
    }
}
