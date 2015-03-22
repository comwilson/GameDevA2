using UnityEngine;
using System.Collections;

public class CreeperController : MonoBehaviour {
	public GameObject target;
	public GameObject spotlight;
	public GameObject playerLight;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		spotlight.transform.LookAt (target.transform.position);
		playerLight.GetComponent<Light> ().intensity = 0.05f;
		transform.LookAt (target.transform.position);
	}
}
