using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject projectilePrefab; // Assign the projectile prefab
    public Transform firePoint;        // Where the projectile spawns
    public float launchForce = 10f;    // Base speed of the projectile

    void Update()
    {
        // Fire on space or left mouse click
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            FireProjectile();
        }
    }

    void FireProjectile()
    {
        // Instantiate the projectile
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        // Apply formula for motion
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        float time = 1f; // Example time duration
        float velocity = launchForce;
        float distance = (0.5f * Physics.gravity.magnitude * time * time) + (velocity * time);

        Vector3 launchVelocity = transform.forward * distance; // Use cannon's forward direction
        rb.AddForce(launchVelocity, ForceMode.VelocityChange);
    }
}
