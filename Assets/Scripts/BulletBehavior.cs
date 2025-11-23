using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    [Header("Bullet Settings")]
    public float bulletSpeed;
    public float bulletDamage;

   
    private void Start()
    {
        // Makes the bullet span infront of the object shooting
        transform.Translate(Vector3.up * 0.8f);
    }

  
    private void Update()
    {
        // Move the bullet forward continuously
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
        
         Destroy(gameObject, 3f);

    }
     
    private void OnTriggerEnter(Collider other)
    {
        // Try to get HealthComponent from the object hit
        Health otherHealth = other.GetComponent<Health>();
        
        // If not on this object, check a different object
        if (otherHealth == null)
        {
            otherHealth = other.GetComponentInParent<Health>();
        }

        // Apply damage if HealthComponent found
        if (otherHealth != null)
        {
            otherHealth.TakeDamage(bulletDamage);
        }

        // Destroy the bullet
        Destroy(gameObject);
    }

    
   
}
