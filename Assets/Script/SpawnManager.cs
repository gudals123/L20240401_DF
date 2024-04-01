using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject enemy;
    public List<GameObject> spawnArea = new List<GameObject>(); 


    public void SpawnEnemy()
    {
        //float randomX = Random.Range(-2f, 2f);  //적이 나타날 x 좌표를 랜덤으로 생성한다.

        if(enableSpawn)
        {

            for(int i = 0; i < spawnArea.Count; i++)
            {
                Instantiate(enemy, spawnArea[i].transform.position, Quaternion.identity);
            }
            //적을 생성한다.
            //Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        }
    }

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 1f);
    }



    void Update()
    {

    }
}
