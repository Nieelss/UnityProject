using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class FogOfWarController : MonoBehaviour
{
    public Tilemap fogTilemap; // Public field for the fog tilemap
    public Transform player; // Public field for the player
    public float revealRadius = 5f; // Radius for revealing tiles

    void Update()
    {
        RevealTiles();
    }

    void RevealTiles()
    {
        Vector3Int playerPosition = fogTilemap.WorldToCell(player.position);

        int intRevealRadius = Mathf.CeilToInt(revealRadius); // Convert float to int

        for (int x = -intRevealRadius; x <= intRevealRadius; x++)
        {
            for (int y = -intRevealRadius; y <= intRevealRadius; y++)
            {
                Vector3Int tilePosition = new Vector3Int(playerPosition.x + x, playerPosition.y + y, playerPosition.z);
                if (Vector3.Distance(player.position, fogTilemap.CellToWorld(tilePosition)) <= revealRadius)
                {
                    fogTilemap.SetTile(tilePosition, null);
                }
            }
        }
    }
}
