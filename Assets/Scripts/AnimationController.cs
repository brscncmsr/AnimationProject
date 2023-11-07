using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator[] Animations;
    public Animator Wave1;
    public Animator Wave2;
    public Animator Wave3;
    public Animator Wave;
    public Animator Hand;
    public Animator Watch;
    public GameObject Sleep;
    public GameObject DbMeter1;
    public GameObject DbMeter2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Watch.enabled = true;
            Hand.enabled = true;
            StartCoroutine(StopTheAnimation());
        }
    }
    IEnumerator StopTheAnimation()
    {
        yield return new WaitForSeconds(2f);
        Sleep.SetActive(true);
        DbMeter1.SetActive(false);
        DbMeter2.SetActive(true);
        Wave1.gameObject.SetActive(false);
        Wave2.gameObject.SetActive(false);
        Wave3.gameObject.SetActive(false);
        Wave.gameObject.SetActive(false);
        for (int i = 0; i < Animations.Length; i++)
        {
            Animations[i].enabled = false;
        }
    }
}
