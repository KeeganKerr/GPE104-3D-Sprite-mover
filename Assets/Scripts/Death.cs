using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Death : MonoBehaviour
{  //Abstarct is strict and requires an override from the child classes in order to function
    public abstract void IsDead();
    
    //Gives the instakill damage zone button something to pull from
    public virtual void InstaKill()
    {
        
        IsDead();
    } 
}
