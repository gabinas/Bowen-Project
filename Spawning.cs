using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour {
    //objects to be spawned in game and their numbers
    public GameObject box;
    public int max = 5;
    public float waitingTime = 2;
    public float countdown = 0;
    private int count=0;

	
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        countdown -= Time.deltaTime;
        if (countdown < 0 && count<max)
        {
            SpawnObjects();
            countdown = waitingTime;
            count++;
        }

	}

    void SpawnObjects()
    {
        box = Instantiate(box, new Vector3(-5,4,0),Quaternion.identity) as GameObject;
    }
}
