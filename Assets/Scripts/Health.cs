using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth;

    public float maxHealth;

    public int lives;

    public Vector3 respawn;

   
    // Start is called before the first frame update
    public virtual void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public virtual void TakeDamage( float amount)
    {
        
         //Checks to see if the pawn is alive and if so deals damage
       currentHealth = currentHealth - amount;
       if ( currentHealth <= 0)
       {
        lives--;

        if(lives > 0)
        {
          currentHealth = maxHealth;
         
        }
        else{
         currentHealth = 0;
         IsDead();
        }
       }
    }
       //Gives the pawn the ability to heal without going past max
    public void Heal ( float amount)
    {
      currentHealth = currentHealth + amount;
      if (currentHealth > maxHealth)
      {
        currentHealth = maxHealth;
      }
    }

  public void IsDead()
  {
     //Handle Death in the Health component
     Death death = GetComponent<Death>();
     if (death != null)
     {
        death.IsDead();
     }
  }
     //Allows the program to tell if the pawn is dead or not
    public bool IsAlive()
    {
       if ( currentHealth > 0)
       {
         return true;
       }
       else
       {
        return false;
       }

    }
}
