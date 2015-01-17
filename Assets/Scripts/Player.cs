using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float velocity;
	public static bool isStraight;
	public static bool isLeft;
	public static bool isRight;
	public static bool isBlocking;
	// Use this for initialization
	private Vector3 startpos;
	private Vector3 direction;
	private float max;
	void Start () {
		isStraight = true;
		isLeft = false;
		isRight = false;
		isBlocking = false;
		max = this.transform.position.x + 3 * 400 * Time.deltaTime;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
				Vector3 speed = Vector3.right * velocity*Time.deltaTime;
				//Debug.Log (speed.x.ToString ());
						
					this.transform.Translate (speed);
					
		}
}
