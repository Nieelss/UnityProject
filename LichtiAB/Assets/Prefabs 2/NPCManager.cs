using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public GameObject npcPrefab;
    public List<Vector2> spawnPoints; // List of specific spawn points

    void Start()
    {
        foreach (Vector2 spawnPoint in spawnPoints)
        {
            Instantiate(npcPrefab, spawnPoint, Quaternion.identity);
        }
    }
}
