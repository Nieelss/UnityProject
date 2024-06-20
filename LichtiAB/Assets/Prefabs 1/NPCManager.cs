using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public GameObject npcPrefab;
    public int npcCount = 10; // Number of NPCs to instantiate
    public float maxDistance = 10f;

    void Start()
    {
        for (int i = 0; i < npcCount; i++)
        {
            Vector2 randomPosition = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
            Instantiate(npcPrefab, randomPosition, Quaternion.identity);
        }
    }
}
