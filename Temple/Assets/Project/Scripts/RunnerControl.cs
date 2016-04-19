using UnityEngine;
using System.Collections;

public class RunnerControl : MonoBehaviour {
    public Game control;
   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cylinder(Clone)")
        {
            control.CoinCollected();
        }

        Destroy(other.gameObject);

    }
}