using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeRandomSpawner : MonoBehaviour
{

    public GameObject Prize;
    public GameObject Prize2;
    public GameObject Prize3;
    private GameObject newObject;
    public Vector3 spawnValues;
    static public bool PrizesSpawned = false;
    //public Vector3 scaleValues;
    private int prizeCount = LevelSelection.PrizeNum;
    public float spawnWait;
    public float startWait;
    public float waveWait;


    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
            prizeCount = prizeCount + 1;
            for (int i = 0; i < prizeCount - 1; i++)
            {
                float RandValue = Random.Range(0.25f, 0.38f);
                int RandPickUp = Random.Range(0, 10);
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x + 0.5f, spawnValues.x), spawnValues.y, Random.Range(-spawnValues.z, spawnValues.z));
                Quaternion spawnRotation = Quaternion.identity;
            if (RandPickUp < 3)
            {
                newObject = Instantiate(Prize, spawnPosition, spawnRotation);
            }
            else if (RandPickUp < 6)
            {
                newObject = Instantiate(Prize2, spawnPosition, spawnRotation);
                RandValue = Random.Range(0.08f, 0.16f);
            }
            else 
            {
                newObject = Instantiate(Prize3, spawnPosition, spawnRotation);
            }
            if (LevelSelection.UniformSize == false)
                {
                    newObject.transform.localScale = new Vector3(RandValue, RandValue, RandValue);
                }
                yield return new WaitForSeconds(spawnWait);
            }
        PrizesSpawned = true;
    }

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }
}

