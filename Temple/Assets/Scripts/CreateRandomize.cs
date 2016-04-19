using UnityEngine;
using System.Collections;

public class CreateRandomize : MonoBehaviour {

	public GameObject Prefab;
	public Vector3 A;
	public Vector3 B;

	public float minSecondsBetweenSpawning = 3.0f;
	public float maxSecondsBetweenSpawning = 6.0f;

	private float savedTime;
	private float secondsBetweenSpawning;

	float Randomize (float A, float B) {
		return Random.Range (A, B);
	}

	Vector3 Randomize (Vector3 A, Vector3 B) {
		return new Vector3 (Randomize (A.x, B.x), Randomize (A.y, B.y), Randomize (A.z, B.z));
	}

	// Use this for initialization
	void Start () {
		savedTime = Time.time;
		secondsBetweenSpawning = Random.Range (minSecondsBetweenSpawning, maxSecondsBetweenSpawning);
	}

	// Update is called once per frame
	void Update () {
		if (Time.time - savedTime >= secondsBetweenSpawning) // is it time to spawn again?
		{
			MakeThingToSpawn();
			savedTime = Time.time; // store for next spawn
			secondsBetweenSpawning = Random.Range (minSecondsBetweenSpawning, maxSecondsBetweenSpawning);
		}	
	}

	void MakeThingToSpawn()
	{
		// create a new gameObject
		GameObject clone = Instantiate(Prefab, Randomize(A, B), transform.rotation) as GameObject;


	}
}
