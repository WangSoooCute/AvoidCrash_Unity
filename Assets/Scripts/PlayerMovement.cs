using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewayForce = 500f;


	// Update is called once per frame
	void FixedUpdate () {
		if (rb.position.z > 185) {
			rb.velocity = Vector3.zero;
			//rigidbody.
		}
        else {
			rb.AddForce(0, 0, forwardForce * Time.deltaTime);
			if (Input.GetKey("j")) {
				rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			}
			if (Input.GetKey("f")) {
				rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			}
			if (rb.position.y < 0) {
				FindObjectOfType<GameManager>().EndGame();
			}
		}
		
	}
}
