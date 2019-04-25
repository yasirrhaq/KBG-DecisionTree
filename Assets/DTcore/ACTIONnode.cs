using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACTIONnode : DTnode {

    public override DTnode makeDecision()
    {
        return this;
    }

    public virtual void doAction()
    {
        //override this for action
    }

}
