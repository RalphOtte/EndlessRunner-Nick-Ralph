using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnData : MonoBehaviour {

    public List<int> stageHeights = new List<int>();          //List which contains the data when to change spawnlist

    public List<Vector3> spawnPoints = new List<Vector3>();   //List with all available spawnpoints
    public List<GameObject> spawnPointObjects = new List<GameObject>(); //Fill THIS one with the spawnpointObjects

    public List<GameObject> spawnStage0 = new List<GameObject>();   //Empty zone
    public List<GameObject> spawnStage1 = new List<GameObject>();   //Bird
    public List<GameObject> spawnStage2 = new List<GameObject>();   //Bird & Hot Air Balloon

    void Update()
    {
        spawnPoints.Clear();
        GetSpawnData();
    }

    void GetSpawnData()
    {
        GameObject.FindGameObjectsWithTag("SpawnPoint");
        foreach(GameObject spawnpoint in spawnPointObjects)
        {
            spawnPoints.Add(spawnpoint.transform.position);
        }
    }
}
