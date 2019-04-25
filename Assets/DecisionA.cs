using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DecisionA : DECISIONnode
{
    public bool isAdaMusuh;
    //overide this methode use your own logic 
    public override bool testDecision()
    {
        Debug.Log("decision A hasil "+ isAdaMusuh);
        return (isAdaMusuh);
    }
}