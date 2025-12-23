using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MakeEnemy : MonoBehaviour
{

    public GameObject[] enemyPrefabs;
    public float spawnInterval;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spawnInterval += 1 * Time.deltaTime;
        if (spawnInterval >= Random.Range(1f, 3f))
        {
            spawnInterval = 0;
            CreateEnemy();
        }

    }
    public void CreateEnemy()
    {
        float x = Random.value > 0.5f ? -11f : 11f;
        int prefabIndex = Random.Range(0, enemyPrefabs.Length);
        GameObject enemy = Instantiate(enemyPrefabs[prefabIndex], new Vector3(x, 0, 0), Quaternion.identity);
        Enemy enemyScript = enemy.GetComponent<Enemy>();
        if (x == 11f)
        {
            enemy.transform.localScale = new Vector3(-Mathf.Abs(enemy.transform.localScale.x), enemy.transform.localScale.y, enemy.transform.localScale.z);
            enemyScript.direction = -1;
        }
        else
        {
            enemyScript.direction = 1;
        }
    }
}
