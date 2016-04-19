using UnityEngine;
using System.Collections;

public class SpawObject : MonoBehaviour {

	GameObject Prefabs;

	// Use this for initialization
	void Start () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject.CreatePrimitive (PrimitiveType.Cube);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
