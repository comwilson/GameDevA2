using UnityEngine;
using System.Collections;

public class SpotlightController : MonoBehaviour {
	public GameObject Player;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float mH = Input.GetAxis ("Horizontal");
		float mV = Input.GetAxis ("Vertical");
		transform.position = Player.transform.position + offset + (new Vector3(mH, 0, mV));
	}
}
