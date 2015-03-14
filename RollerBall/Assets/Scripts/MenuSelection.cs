using UnityEngine;
using System.Collections;

public class MenuSelection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp(){
		if (this.tag == "ExitSelect") {
			Application.Quit ();
		} else if (this.tag == "NewGame"){
			Application.LoadLevel(1);
		
		}
	}

	void OnMouseEnter(){
		this.GetComponent<Renderer> ().material.color = Color.green;
	}
	void OnMouseExit(){
		this.GetComponent<Renderer> ().material.color = Color.white;
	}
}
