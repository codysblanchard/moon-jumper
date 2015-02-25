using UnityEngine;
using System.Collections;

public class FauxGravityAttractor : MonoBehaviour {

	public float gravity = -12;

	public float jumpPower = 200;


	public void Attract(Transform body) {
		Vector3 gravityUp = (body.position - transform.position).normalized;


		Vector3 localUp = body.up;

		body.rigidbody.AddForce(gravityUp * gravity);

		Quaternion targetRotation = Quaternion.FromToRotation(localUp,gravityUp) * body.rotation;
		 body.rotation = Quaternion.Slerp(body.rotation,targetRotation,50f * Time.deltaTime );


		if (Input.GetMouseButtonUp (0) || Input.GetButtonDown ("Fire1")) {

			body.rigidbody.AddForce(gravityUp *  jumpPower);

				}


	}   

}

//