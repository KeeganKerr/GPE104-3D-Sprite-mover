using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathDestroy : Death
{
   public float scoreValue;
   public AudioSource audioSource;
   

   public override void IsDead()
   {
      if (GameManager.instance != null)
      {
         GameManager.instance.AddScore(scoreValue);

         AudioSource.PlayClipAtPoint(GameManager.instance.death, transform.position);

      }


    //Destroy the game object
    Destroy(gameObject, 0.1f);
    

   }
}
