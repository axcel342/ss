using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    private IEnumerator coroutine;
    public float IncrementTime;
    private float CounterTime;
    public GameObject RedCube;
    public GameObject BlueCube;
    public GameObject[] Array;
    private int i;
    // Update is called once per frame

    private void Start()
    {
        i = 0;
        CounterTime = 0;

        coroutine = instantiateCubes(IncrementTime, Array);
        StartCoroutine(coroutine);
    }


    IEnumerator instantiateCubes(float waitTime, GameObject[] cubes)
    {
        //    print("c");

       // CounterTime += IncrementTime;

        for(i = 0; i < 14; i++)
        {
           // cubes[i].SetActive(true);
            Instantiate(cubes[i], transform.position, Quaternion.identity);
            print(i);
            //cubes[i].SetActive(true);
            yield return new WaitForSeconds(waitTime);
        }

        //yield return new WaitForSeconds(waitTime);
        //Instantiate(cube, transform.position, Quaternion.identity);

        //check = false;
        //i++;
        
       //print(i);
      //  print("d");
    }
}
