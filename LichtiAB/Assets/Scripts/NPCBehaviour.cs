using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBehaviour : MonoBehaviour
{
    [SerializeField]
    float speed = 2f;
    [SerializeField]
    float range = 4f;
    [SerializeField]
    float maxDistance = 4f;

    Vector2 wayPoint;
    Vector2 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
        SetNewDestination();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, wayPoint) < range)
        {
            SetNewDestination();
        }
    }

    void SetNewDestination()
    {
        float newX = Random.Range(initialPosition.x - maxDistance, initialPosition.x + maxDistance);
        float newY = Random.Range(initialPosition.y - maxDistance, initialPosition.y + maxDistance);
        wayPoint = new Vector2(newX, newY);
    }
}
