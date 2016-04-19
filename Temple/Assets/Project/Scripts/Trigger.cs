using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        Debug.Log(1);
        Destroy(other.gameObject);
    }
}