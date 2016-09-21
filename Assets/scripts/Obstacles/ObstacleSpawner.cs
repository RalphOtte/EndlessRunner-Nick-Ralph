using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObstacleSpawner : MonoBehaviour {

    private SpawnData spawndata;
    private StageController stageController;
    private int currentStage;

    [SerializeField] private int minInterval;
    [SerializeField] private int maxInterval;
    [SerializeField] private float intervalTimer;

    void Awake()
    {
        spawndata = GetComponent<SpawnData>();
        stageController = GetComponent<StageController>();

        currentStage = 1;

        ResetTimer();
    }
	
	void Update ()
    {
        DetermineList();    //Determines which list to use for spawning

        DecreaseTimer();
        Debug.Log(intervalTimer + "Time remaining until next spawn");
    }

    void DetermineList()
    {
        if (currentStage == 0 && intervalTimer <= 0) { }
        else if (currentStage == 1 && intervalTimer <= 0) { Spawn(spawndata.spawnStage1); }
        else if (currentStage == 2 && intervalTimer <= 0) { Spawn(spawndata.spawnStage2); }
        if (intervalTimer <= 0) { ResetTimer(); }
    }

    void Spawn(List<GameObject> targetList)
    {
        GameObject objectToSpawn = spawndata.spawnStage1[Random.Range(0, targetList.Count)];
        Vector3 spawnPosition = spawndata.spawnPoints[Random.Range(0, spawndata.spawnPoints.Count)];
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }

    void ResetTimer()
    {
        intervalTimer = Random.Range(minInterval, maxInterval);
    }

    void DecreaseTimer()
    {
        intervalTimer -= Time.deltaTime;
    }
}
