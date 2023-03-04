using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plane_Movement : MonoBehaviour
{
    public float speed = 0.55f;
    public Vector3 curr;
    public Vector2 mov;
    public Vector3 movPosX = new Vector3(7f, 0, 0);
    public Vector3 movPosZ = new Vector3(0, 0, 7f);
    public bool directionChosen;
    Touch _touch;
    public float angle;
    private Vector2 pos_a;
    private Vector2 pos_b;
    private int maxC = 3;
    private int c = 3;

    private Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            curr = rb.position;
            _touch = Input.GetTouch(0);
            switch (_touch.phase)
            {
                case TouchPhase.Began:
                    print("Touched.");
                    break;
                case TouchPhase.Moved:
                    if (c == maxC) { pos_a = _touch.position; c--; }
                    else if (c > 0) { c--; }
                    if (!directionChosen && c == 0)
                    {
                        pos_b = _touch.position;
                        Vector2 swipe = pos_b - pos_a;
                        angle = Vector2.SignedAngle(Vector2.right, swipe);
                        if(angle > 0 && angle < 90)
                            rb.MovePosition(curr + movPosZ);
                        else if(angle > 90 && angle < 180)
                            rb.MovePosition(curr - movPosX);
                        else if (angle < 0 && angle > -90)
                            rb.MovePosition(curr + movPosX);
                        else if (angle > -180 && angle < -90)
                            rb.MovePosition(curr - movPosZ);
                        directionChosen = true;
                        c = maxC;
                    }
                    break;
                case TouchPhase.Ended:
                    directionChosen = false;
                    c = maxC;
                    break;
            }
        }
    }


    void ApplyMovement(Vector2 deltaPosition)
    {

    }
}