using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSlow : Move
{
    bool speede;
    // Start is called before the first frame update
    public override void Moved()
    {
        if (speede == true)
            speed = speed / 2;
        else speed = 50;

        base.Moved();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "slowD")
            speede = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "slowD")
            speede = false;
    }
}
