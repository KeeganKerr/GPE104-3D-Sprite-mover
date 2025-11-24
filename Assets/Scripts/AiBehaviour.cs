using UnityEngine;

public class AiBehaviour : MonoBehaviour
{
    
    public float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
   
        public void Chase(Vector3 position)
        {
        transform.position = Vector3.MoveTowards(transform.position, position, moveSpeed * Time.deltaTime);
        }
    
}
