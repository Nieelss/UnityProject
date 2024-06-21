using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NPCSpawnInfo
{
    public GameObject npcPrefab; // The prefab to instantiate
    public Vector2 spawnPoint; // The position to instantiate the NPC
}

public class NPCManager : MonoBehaviour
{
    public List<NPCSpawnInfo> npcSpawnInfos; // List of NPC spawn information

    void Start()
    {
        foreach (NPCSpawnInfo spawnInfo in npcSpawnInfos)
        {
            Instantiate(spawnInfo.npcPrefab, spawnInfo.spawnPoint, Quaternion.identity);
        }
    }
}
