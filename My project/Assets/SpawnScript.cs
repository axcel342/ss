using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    private IEnumerator coroutine;
    public float IncrementTime;
    public GameObject RedCube;
    public GameObject BlueCube;
    public GameObject[] Array;
    private int i;
    // Update is called once per frame

    private void Start()
    {
        i = 0;

        coroutine = instantiateCubes(IncrementTime, Array);
        StartCoroutine(coroutine);
    }


    IEnumerator instantiateCubes(float waitTime, GameObject[] cubes)
    {


        for(i = 0; i < cubes.Length; i++)
        {

            Instantiate(cubes[i], transform.position, Quaternion.identity);
            print(i);
            if(i == cubes.Length - 1)
            {

                Invoke("Retry", 3.0f);
               
            }

            yield return new WaitForSeconds(waitTime);
        }


    }

    private void Retry()
    {
        FindObjectOfType<GameManager>().Retry();
    }
}


