using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCarcade : MonoBehaviour
{

    public GameObject[] ObstaclesPrefab;
    public GameObject[] Boss;
    public GameObject[] Points;
    public GameObject[] Comp; 
    private Vector3 pSpawnPos = new Vector3 (50, 2, 0);
    private Vector3 spawnPos = new Vector3 (25, 0, 0);
    private Vector3 cSpawnPos = new Vector3 (50, -1, 0);
    private Vector3 bSpawnPos = new Vector3 (30 , 0, 0);
    private IEnumerator couroutine;
    private IEnumerator couroutineP;
    private IEnumerator couroutineC;

    void Start()
    {
        couroutine = SpawnObstacle();
        StartCoroutine(couroutine);

        couroutineP = SpawnPoints();
        StartCoroutine(couroutineP);
        
        couroutineC = SpawnComp();
        StartCoroutine(couroutineC);
    }

    private IEnumerator SpawnObstacle()
    {
        while (true)
        {
            if(!GameControler.gameOver) CreateObstacle();
            yield return new WaitForSeconds(GameControler.TimeToSpawn );
            if(!GameControler.gameOver && GameControler.score > 80f) CreateBoss();
        }
    }

    private IEnumerator SpawnPoints()
    {
        while (true)
        {
            if(!GameControler.gameOver) CreatePoints();
            yield return new WaitForSeconds(GameControler.TimeToSpawn );
        }
    }

    private IEnumerator SpawnComp()
    {
        while (true)
        {
            if(!GameControler.gameOver) CreateComp();
            yield return new WaitForSeconds(GameControler.TimeToSpawn );
        }
    }
    
    private void CreateObstacle()
    {
        GameObject obstacle = ObstaclesPrefab[Random.Range(0, ObstaclesPrefab.Length-1)];
        Instantiate (obstacle, spawnPos, obstacle.transform.rotation);
    }

    private void CreateBoss()
    {
        GameObject boss = Boss[Random.Range(0, Boss.Length-1)];
        Instantiate (boss, bSpawnPos, boss.transform.rotation);
    }

    private void CreatePoints()
    {
        GameObject points = Points[Random.Range(0, Points.Length-1)];
        Instantiate (points, pSpawnPos, points.transform.rotation);
    }

    private void CreateComp()
    {
        GameObject comp = Comp[Random.Range(0, Comp.Length-1)];
        Instantiate (comp, cSpawnPos, comp.transform.rotation);
    }

}