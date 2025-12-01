using UnityEngine;
using System.Collections.Generic;
public class LevelLimit : MonoBehaviour
{
    public Vector3 size;
    
    public List<Spawner> childScripts = new List<Spawner>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawner[] foundScripts = GetComponentsInChildren<Spawner>(true);

        foreach (Spawner script in foundScripts)
        {
            childScripts.Add(script);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
