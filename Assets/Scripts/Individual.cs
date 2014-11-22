using UnityEngine;
using System.Collections;

public class Individual : MonoBehaviour {

	public int index;
	private bool isEnabled;
	void Awake(){
		isEnabled = Girls.girl1[index];
	}
	// Use this for initialization
	void Start () {
		//Debug.Log (.girl1 [index].ToString ());
		if (isEnabled) {
			renderer.enabled = true;
		} else {
			renderer.enabled=false;
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
