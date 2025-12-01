using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Death : MonoBehaviour
{  //Abstarct is strict and requires an override from the child classes in order to function
    public abstract void IsDead();
    
    //Gives the instakill damage zone button something to pull from
    public virtual void InstaKill()
    {
        
       Health health = GetComponent<Health>();

        if (health != null)
        {
            health.lives--;

            if (health.lives > 0)
            {
                // resets health to max when killed 
                health.currentHealth = health.maxHealth;
            }
            else
            {
                // kills the player if there are no lives remaining
                health.currentHealth = 0;
                IsDead();
            }
        }
        else
        {
           
            IsDead();
        }

    } 
}
