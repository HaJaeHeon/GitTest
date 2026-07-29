using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] ObjectPooling pool;
    [SerializeField] Transform parentSpawnPointTransform;
    [SerializeField] float spawnInterval;
    [SerializeField] int spawnCount;

    public List<Transform> spawnPointsList = new List<Transform>();
    private float spawnTimer;

    private void OnEnable()
    {
        parentSpawnPointTransform = GameObject.FindAnyObjectByType<SpawnPoint>().transform;

        if(parentSpawnPointTransform == null || parentSpawnPointTransform.childCount <= 0)
        {
            Debug.Log("ParentTransform null or parentsChild null");
            return;
        }
        for (int i = 0; i < parentSpawnPointTransform.childCount; i++)
        {
            spawnPointsList.Add(parentSpawnPointTransform.transform.GetChild(i).transform);
        }
    }
    private void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer > spawnInterval)
        {
            SpawnEnemy();
            spawnTimer = 0;
        }
    }

    private void SpawnEnemy()
    {
        GameObject enemy = pool.Get();

        int randomCount = Random.Range(0, spawnPointsList.Count);

        enemy.transform.position = spawnPointsList[randomCount].position;
        enemy.GetComponent<EnemyMove>().playerTransform = this.playerTransform;
        enemy.SetActive(true);
    }
}
