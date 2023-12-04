using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject powerupPrefab;
    public GameObject powerupBallPrefab;

    private float spawnRange = 2;
    private int numberPowerup;
    // Start is called before the first frame update
    void Start()
    { 
        InvokeRepeating("LaunchPowerupPrefab", 2.0f, 3.0f);        
    }
    void LaunchPowerupPrefab() 
    {
        if(numberPowerup == 0) Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
    }
    private Vector3 GenerateSpawnPosition() 
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosY = Random.Range(1.2f, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, 0);
        return randomPos;
    }
    // Update is called once per frame
    void Update()
    {
        numberPowerup = GameObject.FindGameObjectsWithTag("Powerup").Length;
    }
}
