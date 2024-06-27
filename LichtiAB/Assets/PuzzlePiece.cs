using UnityEngine;

public class PuzzlePiece : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;

    public Transform correctPosition;  // Set this in the Inspector

    void OnMouseDown()
    {
        isDragging = true;
        offset = transform.position - GetMouseWorldPosition();
    }

    void OnMouseUp()
    {
        isDragging = false;
        CheckCorrectPosition();
    }

    void Update()
    {
        if (isDragging)
        {
            transform.position = GetMouseWorldPosition() + offset;
        }
    }

    Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void CheckCorrectPosition()
    {
        // Define a tolerance for snapping the piece to the correct position
        float tolerance = 0.5f;

        if (Vector3.Distance(transform.position, correctPosition.position) < tolerance)
        {
            transform.position = correctPosition.position;
            // Optionally, lock the piece in place
            GetComponent<BoxCollider2D>().enabled = false;
            isDragging = false;
        }
    }
}
