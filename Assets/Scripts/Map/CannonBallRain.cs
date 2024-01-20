using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CannonBallRain : MonoBehaviour
{

    // take the prefab of the cannonballs
    public GameObject cannonBallPrefab;

    // set a limit to the number of CannonBalls spawned at a moment
    [SerializeField]
    private List<GameObject> cannonBallsSpawned = new List<GameObject>(); // no of cannonballs currently spawned
    public int cannonBallLimit = 10; // max no of cannonballs at one instance
    public float cannonBallSpawnCooldown = 5; // cooldown in seconds
    public float lastCannonballSpawnTime = 0; // timing in s i think

    void Start()
    {
        
    }
    float RngCoordinates()
    {
        return Random.Range(-15.0f, 15.0f);

    }

    Vector3 getRandomVector3Coordinates()
    {
        // mainly x and z, y is always the same
        // x randomly generate
        Vector3 spawnedCoordinates = new Vector3(RngCoordinates(), 0, RngCoordinates());
        return spawnedCoordinates;

    }

    void spawnCannonBall()
    {
        // check if cooldown exceed
        // check if no of cannonballs exceed
        if(Time.time >= lastCannonballSpawnTime + cannonBallSpawnCooldown && cannonBallsSpawned.Count < cannonBallLimit)
        {
            GameObject newlySpawnedCannonball = Instantiate(cannonBallPrefab, getRandomVector3Coordinates(), gameObject.transform.rotation);
            newlySpawnedCannonball.transform.SetParent(gameObject.transform);
            cannonBallsSpawned.Add(newlySpawnedCannonball);
            lastCannonballSpawnTime = Time.time;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = cannonBallsSpawned.Count - 1; i >= 0; i --)
        {
            GameObject currentCannonBall = cannonBallsSpawned[i];
            PlayerCollision cannonBallCollision = currentCannonBall.GetComponent<PlayerCollision>();
            if (cannonBallCollision != null && cannonBallCollision.toDespawn == true)
            {
                Destroy(currentCannonBall);
                cannonBallsSpawned.RemoveAt(i);
            }
        }
        spawnCannonBall();
    }
}
