using UnityEngine;
using System.Collections;

public class LevelChangeController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		if (Application.loadedLevel < Application.levelCount - 1) {
			Application.LoadLevel(Application.loadedLevel + 1);
		}
		else
		{
			Application.LoadLevel (0);
		}
	}
}
