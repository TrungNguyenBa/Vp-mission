using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float velocity;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 speed = Vector3.right * velocity;
		speed *= Time.deltaTime;
		this.transform.Translate (speed);
	}
}
