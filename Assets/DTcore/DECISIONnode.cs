using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DECISIONnode : DTnode {
    public DTnode trueBranch;
    public DTnode falseBranch;

    public override DTnode makeDecision()
    {
        if (testDecision())
        {
            if (trueBranch != null)
            { return trueBranch.makeDecision(); }
            else
            {
                return null;
            }
        }
        else
        {
            if (falseBranch != null)
            { return falseBranch.makeDecision(); }
            else
            {
                return null;
            }
        }
    }

    //overide this methode use your own logic 
    public virtual bool testDecision()
    {
        return false;
    }
}
