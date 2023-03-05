using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape_hit : MonoBehaviour
{
    public Vector3[] positions;
    public GameObject[] shapes;
    public int numberOfPoints;

    private void OnTriggerEnter(Collider other)
    {
       
        if(other.tag == "Red Tag")
        {
            print("Recieved");
            other.gameObject.SetActive(false);

            if (other.gameObject.GetComponent<MeshRenderer>().material.color == Color.red && other.tag == "Red Tag")
            {
                GetComponent<MeshRenderer>().material.color = Color.red;
              
            }

            else if(other.gameObject.GetComponent<MeshRenderer>().material.color == Color.blue && other.tag == "Blue Tag")
            {
                GetComponent<MeshRenderer>().material.color = Color.blue;
               
            }

        }

        if (other.tag == "Blue Tag")
        {
            print("Recieved");
            other.gameObject.SetActive(false);

            if (other.gameObject.GetComponent<MeshRenderer>().material.color == Color.red && other.tag == "Red Tag")
            {
                GetComponent<MeshRenderer>().material.color = Color.red;

            }

            else if (other.gameObject.GetComponent<MeshRenderer>().material.color == Color.blue && other.tag == "Blue Tag")
            {
                GetComponent<MeshRenderer>().material.color = Color.blue;

            }

        }




    }
}
