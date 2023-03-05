using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape_hit : MonoBehaviour
{
    public Vector3[] positions;
    public GameObject[] shapes;
    public int numberOfPoints;
    // Start is called before the first frame update
    void Start()
    {
        shapes = GameObject.FindGameObjectsWithTag("Cutout");
        positions = new Vector3[shapes.Length];
        for (int i = 0; i < shapes.Length; i++)
        {
            positions[i] = shapes[i].transform.position - Vector3.down * Random.Range(5, 12);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if(other.tag == "Shape")
        {
            print("Recieved");
            other.gameObject.SetActive(false);
            //     int randomNumber = Random.Range(0, positions.Length);
            //    other.gameObject.transform.position = positions[randomNumber];
            // other.gameObject.transform.position = new Vector3(0, 37, 0);

            //Object.Destroy(other.gameObject);

            if (other.gameObject.GetComponent<MeshRenderer>().material.color == Color.red)
            {
                GetComponent<MeshRenderer>().material.color = Color.red;
            }

            else if(other.gameObject.GetComponent<MeshRenderer>().material.color == Color.blue)
            {
                GetComponent<MeshRenderer>().material.color = Color.blue;
            }

        }
    }
}
