using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This script will be placed in the spawner
/// </summary>

public class SpawnPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerPrefab;
    void Start()
    {
        float xPos = gameObject.transform.position.x;
        float yPos = gameObject.transform.position.y+ 0.5f;
        float zPos = gameObject.transform.position.z;
        Instantiate(playerPrefab, new Vector3(xPos,yPos,zPos), gameObject.transform.rotation);

    }

}
