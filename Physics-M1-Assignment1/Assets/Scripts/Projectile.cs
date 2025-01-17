using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Calculate and log the distance
        float distance = Vector3.Distance(startPosition, transform.position);
        Debug.Log("Distance traveled: " + distance);

        // Destroy the projectile after collision
        Destroy(gameObject);
    }
}
