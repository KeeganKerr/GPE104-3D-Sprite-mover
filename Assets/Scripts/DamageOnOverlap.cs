using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnOverlap : MonoBehaviour
{
    public float damageDone;
    public bool isInstaKill;
    public bool canDamage;
     
     //on trigger runs the proccess of the pawn taking damage or being killed via hitbox
    void OnTriggerEnter(Collider other)
    {
         if (!canDamage) return;

        // Only damage the player
        if (!other.CompareTag("Player")) return;

        Debug.Log("Hit! " + other.gameObject.name);

        Health otherHealth = other.gameObject.GetComponent<Health>();

        if (otherHealth != null)
        {    //Checks if the instakill is checkmarked and if not does normal damage
            if (isInstaKill)
            {
                Death death = otherHealth.GetComponent<Death>();

                if (death != null)
                {
                    death.InstaKill();
                }
                else
                {
                    
                    otherHealth.TakeDamage(otherHealth.currentHealth);
                }
            }
            else
            {
                
                otherHealth.TakeDamage(damageDone);
            }
        }
    }

    void Start()
    {
        
        // tells the game manager to add up the zones
        GameManager.instance.damageZones.Add(this);
        
    }

    void Update()
    {
        
    }
    void OnDestroy()
    {
        
        // tells the game manager to subtract a zone
        GameManager.instance.damageZones.Remove(this);
        
        
    }
}
