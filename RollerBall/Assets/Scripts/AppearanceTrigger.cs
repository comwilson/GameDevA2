using UnityEngine;
using System.Collections;

public class AppearanceTrigger : MonoBehaviour {

	public GameObject TriggerObject;
	public bool StartState;
	// Use this for initialization
	void Start () {
		TriggerObject.SetActive (StartState);
	}

	void OnTriggerEnter(Collider col)
	{
		TriggerObject.SetActive (!StartState);
	}

}
