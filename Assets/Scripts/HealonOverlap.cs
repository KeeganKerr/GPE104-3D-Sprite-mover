using UnityEngine;

public class HealonOverlap : MonoBehaviour
{

    public float healingDone;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        Health otherHealth = other.gameObject.GetComponent<Health>();
        {
            otherHealth.Heal(otherHealth.currentHealth);

            Destroy(gameObject, 0.1f);
        }

        
    }
}
