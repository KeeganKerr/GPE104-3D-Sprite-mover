using UnityEngine;

public class InstaKill : MonoBehaviour
{

    public bool IsInstaKill;
    public bool canDamage;
    void OnTriggerEnter(Collider other)
    {
         if (!canDamage) return;

        // Only damage the player
        if (!other.CompareTag("Player")) return;

        Debug.Log("Hit! " + other.gameObject.name);

        Health otherHealth = other.gameObject.GetComponent<Health>();

        if (otherHealth != null)
        {    //Checks if the instakill is checkmarked and if not does normal damage
            if (IsInstaKill)
            {
                Death death = otherHealth.GetComponent<Death>();

                if (death != null)
                {
                    death.InstaKill();
                }
              }  
        }
    }

}
