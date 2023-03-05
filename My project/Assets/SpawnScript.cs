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
    private bool check = false;
    private int i;
    // Update is called once per frame

    private void Start()
    {
        i = 0;
        CounterTime = 0;
    }
    void Update()
    {



        if (i < 13 && check == false)
        {
         //   print("a");
            coroutine = instantiateCubes(CounterTime, Array[i]);
            check = true;
            StartCoroutine(coroutine);
            print(i);

            //  print("b");
        }

        else
            print("end");

        
    }

    IEnumerator instantiateCubes(float waitTime, GameObject cube)
    {
        //    print("c");

        CounterTime += IncrementTime;
        yield return new WaitForSeconds(waitTime);
        Instantiate(cube, transform.position, Quaternion.identity);

        check = false;
        i++;
        cube.SetActive(true);
       print(i);
      //  print("d");
    }
}
