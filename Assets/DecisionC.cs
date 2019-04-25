using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionC : DECISIONnode {

    public int jarak;
    //overide this methode use your own logic 
    public override bool testDecision()
    {
        Debug.Log("decision C hasil " + (jarak > 30));
        return (jarak > 30);
    }
}
