using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject characterLocation;
    public GameObject platformPrefab;
    public int platformsPerLevel = 20;
    private int level = 4;
    private float lastPlatformHeight = 0;
    private float lastPlayerHeight = -20;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (characterLocation.transform.position.y > lastPlayerHeight)
        {
            for (int i = 0; i < platformsPerLevel; i++)
            {
                Vector3 spawnPosition = new Vector3();
                spawnPosition.x = Random.Range(-12f, 12f);
                spawnPosition.y = lastPlatformHeight + (i * level);
                Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            }
            lastPlayerHeight += platformsPerLevel * level;
            lastPlatformHeight += platformsPerLevel * level;
            level++;
        }


    }
}
