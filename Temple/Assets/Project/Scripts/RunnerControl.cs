using UnityEngine;
using System.Collections;

public class RunnerControl : MonoBehaviour {
    public Game control;

    void Start()
    {
        Debug.Log(2);
    }
   
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Cylinder(Clone)")
        {
            control.CoinCollected();
        }

        Destroy(other.gameObject);

    }
}