using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject package;
    [Space(3)]
    public float waitingForNextSpawn = 12;
    public float theCountdown = 5;

    void Start()
    {
        Debug.Log("Start");
    }
    public void Update() {
        theCountdown -= Time.deltaTime;
          if(theCountdown <= 0)
          {
            Debug.Log("SOMETHING JUST SPAWNED LOOK FOR IT");
            SpawnGoodies ();
            theCountdown = waitingForNextSpawn;
          }
    }
    void SpawnGoodies()
      {
        //Vector2 pos = new Vector2 (Random.Range (xMin, xMax), Random.Range (yMin, yMax));
        float x = Random.Range (-50f, 50f);
        float y = Random.Range (-50f, 50f);

        Debug.Log("PLEASE WORK");
        Instantiate(package, new Vector3(x,y,0), Quaternion.identity);
        Debug.Log("houston we have liftoff");
      }
}
//MAIN CAMERA SIZE 13
