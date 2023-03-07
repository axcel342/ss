using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape_hit : MonoBehaviour
{
    public Vector3[] positions;
    public GameObject[] shapes;
    private int numberOfPoints;
    public int numberOfTiles;

    private void Start()
    {
        numberOfPoints = 0;
        FindObjectOfType<GameManager>().SetTotalTiles(numberOfTiles);
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if(other.tag == tag && tag == "Red Tag")
        {

            other.gameObject.SetActive(false);

            if (other.gameObject.GetComponent<MeshRenderer>().material.color == Color.red && GetComponent<MeshRenderer>().material.color != Color.red)
            {
                GetComponent<MeshRenderer>().material.color = Color.red;

                FindObjectOfType<GameManager>().IncrementTileCount();
            }

            else
            {
                print("Rejected");
                other.gameObject.SetActive(false);
            }



                    }

        if (other.tag == tag && tag == "Blue Tag")
        {
  
            other.gameObject.SetActive(false);
            if (other.gameObject.GetComponent<MeshRenderer>().material.color == Color.blue && GetComponent<MeshRenderer>().material.color != Color.blue)
            {
                GetComponent<MeshRenderer>().material.color = Color.blue;

                FindObjectOfType<GameManager>().IncrementTileCount();
            }

            else
            {
                print("Rejected");
                other.gameObject.SetActive(false);
            }


        }

        if (other.tag == tag && tag == "Green Tag")
        {

            other.gameObject.SetActive(false);
            if (other.gameObject.GetComponent<MeshRenderer>().material.color == Color.green && GetComponent<MeshRenderer>().material.color != Color.green)
            {
                GetComponent<MeshRenderer>().material.color = Color.green;

                FindObjectOfType<GameManager>().IncrementTileCount();
            }

            else
            {
                print("Rejected");
                other.gameObject.SetActive(false);
            }


        }

        if (other.tag == tag && tag == "Yellow Tag")
        {

            other.gameObject.SetActive(false);
            if ( GetComponent<MeshRenderer>().material.color != Color.yellow)
            {
                GetComponent<MeshRenderer>().material.color = Color.yellow;

                FindObjectOfType<GameManager>().IncrementTileCount();
            }

            else
            {
                print("Rejected yellow" + other.gameObject.GetComponent<MeshRenderer>().material.color);
                other.gameObject.SetActive(false);
            }


        }

        else if( other.tag != "Cutout" )
        {
            print("Rejected");
            other.gameObject.SetActive(false);
        }

        if(numberOfPoints == 9)
        {
            print("Endgame");
        }


    }
}
