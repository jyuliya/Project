using UnityEngine;
using System.Collections;

public class RunnerControl : MonoBehaviour {
    public Game control;

    void Start()
    {
    }
   
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "Cylinder(Clone)")
        {
            control.CoinCollected();
        }
        if (other.gameObject.name == "Obtacle(Clone)")
        {
            control.obtacleTouch();
        }
        Destroy(other.gameObject);

    }
}