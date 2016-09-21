using UnityEngine;
using System.Collections;

public class StageController : MonoBehaviour {

    public ObstacleSpawner obstacleSpawner;
    public SpawnData spawnData;
    public int currentStage;
    public int nextStage;
    //public Player player;

    public int nextStageHeight;

    void Start()
    {
        obstacleSpawner = GetComponent<ObstacleSpawner>();
        spawnData = GetComponent<SpawnData>();
        //player = GetComponent<Player>();
    }

    void Update()
    {
        nextStage = currentStage + 1;
        CheckStage();
    }

    void CheckStage()
    {
        // if(player.yPos >= nextStageHeight){ ChangeStage(); }
    }

    void ChangeStage()
    {
        currentStage++;
    }
}
