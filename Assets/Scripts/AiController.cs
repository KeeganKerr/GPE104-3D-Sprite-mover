using UnityEngine;

public class AiController : MonoBehaviour
{
 
 public AiBehaviour AiBehaviour;
 private Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if( target == null)
        return;

        AiBehaviour.Chase(target.position);
    }
}
