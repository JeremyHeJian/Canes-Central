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
        twoToThreeButton.SetActive(false);
        threeToFourButton.SetActive(true);

        nameOrder.SetActive(true);

        anim.Play();
        anim.CrossFade("idle_00");
    }
}
