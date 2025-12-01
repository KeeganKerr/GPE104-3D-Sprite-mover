using UnityEngine;

public class ScoreOnOverlap : MonoBehaviour
{
    public float scoreValue;
   
 void OnTriggerEnter(Collider other)
 {
    if (GameManager.instance != null)
      {
         GameManager.instance.AddScore(scoreValue);

         Destroy(gameObject, 0.1f);
      }
}
}