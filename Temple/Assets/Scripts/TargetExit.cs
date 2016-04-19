using UnityEngine;
using System.Collections;

public class TargetExit : MonoBehaviour {

	public float minTime = 3f;
	public float maxTime = 6f;
		
	public float LifeTime = 0f;

	// Use this for initialization
	void Start () {
		LifeTime = Random.Range (minTime, maxTime);
	}
	
	// Update is called once per frame
	void Update () {
		LifeTime -= Time.deltaTime;
		if (LifeTime <= 0) {
			Destroy (gameObject);
		}
	}
}