using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionB : ACTIONnode {

    public Text result;

    public override void doAction()
    {
        result.text = "lari";
    }
}
