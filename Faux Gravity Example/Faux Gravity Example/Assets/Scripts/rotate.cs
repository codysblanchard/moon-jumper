using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (homePlanet) {
			speed = homePlanetSpeed;
		}
		else speed = Random.Range (2,6);
	}
	private float speed = 10F;
	public bool homePlanet=false;
	public float homePlanetSpeed = 2F;
	
	void Update ()
	{
		transform.Rotate(Vector3.up, speed * Time.deltaTime);
	}
}
