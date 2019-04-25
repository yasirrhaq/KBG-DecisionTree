using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionB : DECISIONnode {

    public int Health;
    //overide this methode use your own logic 
    public override bool testDecision()
    {
        Debug.Log("decision B hasil " + (Health > 50));
        return (Health > 50);
    }
}
