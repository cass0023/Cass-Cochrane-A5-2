using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public float platformCount;
    public Vector3 spawnPosition;
    private float levelCheck;
    private float platformsPerLevel;
    public GameObject characterLocation;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (float i = 0; i < platformCount; i++)
        {
            Screen.SetResolution(600, 800, true);

            levelCheck = -platformsPerLevel / 2;
        }
    }

    void Update()
    {
        //creates platforms into levels, starting with 2 units per platform
        if (characterLocation.transform.position.y > levelCheck)

        {
            spawnPosition.y = Random.Range(-15f, 100f);
            spawnPosition.x = Random.Range(-12f, 12f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
