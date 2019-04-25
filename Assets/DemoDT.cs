using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoDT : MonoBehaviour {

    public DTnode [] nodes;
    // Use this for initialization
    void Start()
    {
        nodes = GetComponents<DTnode>();
    }

    // Update is called once per frame
    void Update () {
        ACTIONnode act = (ACTIONnode)nodes[0].makeDecision();
        act.doAction();
	}
}