using UnityEngine;
using System.Collections;

public class CameraTargetController : MonoBehaviour {
	public GameObject Player;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Player.transform.position.x + offset.x, offset.y, Player.transform.position.z + offset.z);
	}
}
