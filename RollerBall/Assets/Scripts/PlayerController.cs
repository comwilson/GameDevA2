using UnityEngine;
using System.Collections;
public class PlayerController : MonoBehaviour {
	public float speed;
	public GameObject ExitIndicator;
	public GameObject ExitTrigger;

	private int count;
	
	public int pickupsToExit;
	// Use this for initialization
	void Start () {
		ExitIndicator.SetActive (false);
		ExitTrigger.SetActive (false);
	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		var rb = this.GetComponent<Rigidbody> ();

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);
		rb.AddForce (movement * speed * Time.deltaTime);
		// Slow down if the player isn't trying to move:
		if (!(Mathf.Abs(moveHorizontal) > 0.0f || Mathf.Abs(moveVertical) > 0.0f)) {
			rb.velocity *= 0.95f;
			if (rb.velocity.magnitude < 0.5f) {
				rb.velocity = Vector3.zero;
			}
		}


	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Pickup") {
			col.gameObject.SetActive(false);
			count += 1;
			if (count == pickupsToExit)
			{
				ExitTrigger.SetActive(true);
				ExitIndicator.SetActive(true);
			}
		}
	}
}
