using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float velocity;
	public static bool isStraight;
	public static bool isLeft;
	public static bool isRight;
	// Use this for initialization
	private Vector3 startpos;
	private Vector3 direction;
	void Start () {
		isStraight = true;
		isLeft = true;
		isRight = false;
	}
	
	// Update is called once per frame
	void Update () {
				Vector3 speed = Vector3.right * velocity;
				speed *= Time.deltaTime;
				this.transform.Translate (speed);
				
		}
}
