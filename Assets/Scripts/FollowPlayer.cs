using UnityEngine;

public class GhostController : MonoBehaviour
{
    public Transform pacman;
    public LayerMask obstacleLayer;
    public float speed = 5f;

    void Update()
    {
        // Check if Pacman is available
        if (pacman != null)
        {
            // Calculate direction towards Pacman
            Vector3 direction = (pacman.position - transform.position).normalized;

            // Raycast to check for obstacles in the path
            RaycastHit hit;
            if (Physics.Raycast(transform.position, direction, out hit, Mathf.Infinity, obstacleLayer))
            {
                // If there is an obstacle, don't move directly towards Pacman
                Debug.DrawRay(transform.position, direction * hit.distance, Color.red);
            }
            else
            {
                // Move the ghost towards Pacman
                transform.Translate(direction * speed * Time.deltaTime);
            }
        }
    }
}
