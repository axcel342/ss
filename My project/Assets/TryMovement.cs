using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryMovement : MonoBehaviour
{
    public float speed = 10f;
    public GameObject ArrowLeft1;
    public GameObject ArrowLeft2;
    public GameObject ArrowRight1;
    public GameObject ArrowRight2;

    private CharacterController controller;
    private Vector3 moveVector;
    public bool moveleft = true;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            ApplyMovement(touchDeltaPosition);
            controller.Move(moveVector);
        }
    }

    void ApplyMovement(Vector2 deltaPosition)
    {
        float x = deltaPosition.x * speed * Time.deltaTime;
        float y = deltaPosition.y * speed * Time.deltaTime;
       // float z = 1.0f; // Set the Z direction force value here

        if(moveleft == true)
        {
            moveVector = new Vector3(-y, 0, 0);
        }

        else
            moveVector = new Vector3(0, 0, x);





        //  rb.AddForce(movement);
    }

    public void reverseMotion()
    {
        if (moveleft == true)
            moveleft = false;
        else
            moveleft = true;

        if(ArrowLeft1.activeInHierarchy)
        {
            ArrowLeft1.SetActive(false);
            ArrowLeft2.SetActive(false);
            ArrowRight1.SetActive(true);
            ArrowRight2.SetActive(true);
        }

        else
        {
            ArrowLeft1.SetActive(true);
            ArrowLeft2.SetActive(true);
            ArrowRight1.SetActive(false);
            ArrowRight2.SetActive(false);
        }



    }



}


