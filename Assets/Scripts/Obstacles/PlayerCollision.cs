using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerCollision : MonoBehaviour
{
    // Use this for initialization
    public float spawnedTime;
    public float spawnLifeTime = 60;
    public bool toDespawn = false;
    public List<GameObject> spawnerArray;


    void OnCollisionEnter(Collision collision)
    {
        Player checkPlayer = collision.gameObject.GetComponent<Player>();
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (checkPlayer != null && Time.time >= checkPlayer.lastHit + checkPlayer.lastHitCooldown)
        {
            checkPlayer.lastHit = Time.time;
            checkPlayer.noOfLives -= 1;
            toDespawn = true;
        }
    }

    void Start()
    {
        //despawnGameObject(true);
        spawnedTime = Time.time;
    }

    void Update()
    {
        if(Time.time > spawnedTime + spawnLifeTime)
        {
            toDespawn = true;
        }
    }
}

