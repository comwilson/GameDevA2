using UnityEngine;
using System.Collections;

public class TeleportController : MonoBehaviour {

	public GameObject ParticleEmitter;

	public Vector3 TeleportCoordinates;

	private GameObject teleportTarget;
	// Use this for initialization
	void Start () {
		ParticleEmitter.SetActive (false);
	}

	void OnTriggerEnter(Collider col)
	{
		ParticleEmitter.SetActive (true);

		Invoke ("Teleport", 0.5f);

		teleportTarget = col.gameObject;
	}

	void Teleport()
	{
		teleportTarget.transform.position = TeleportCoordinates;
	}
}
