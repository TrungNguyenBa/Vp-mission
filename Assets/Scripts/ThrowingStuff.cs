using UnityEngine;
using System.Collections;

public class ThrowingStuff : MonoBehaviour {

//	private Transform[]shooting = new Transform[8]; 
	static public bool shoot=false;
	static public float delay=1f;
	private GameObject[] things;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		things = GameObject.FindGameObjectsWithTag("throwing");
			//Debug.Log (delay.ToString());
		if (things != null) {
						if (ThrowingStuff.shoot) {
								if (delay > 0) {
										delay -= Time.fixedDeltaTime;
								} else {
										delay = 1.2f - Point.level * 0.065f;
										if (delay < 0.4)
												delay = 0.4F;
										shoot = false;
								}
						} else {
								int random = (int)Random.Range (0, things.Length -0.0001f);
								things [random].SendMessage ("isthrowing");
						}
				}

	}


}
