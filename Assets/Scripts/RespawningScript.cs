using UnityEngine;
using System.Collections;

public class RespawningScript : MonoBehaviour {
	public GameObject girls; 
	private float delay;
//	public GameObject pc;
	//public GameObject throwing;
	// Use this for initialization
	private int times;
	public GameObject thing;
	void Start () {
		delay = 1f;
		times = 1;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dis = new Vector3 (18.5f*times, 0, 0);
		if (delay <= 0) {
						Instantiate (girls,girls.transform.position+dis , Quaternion.identity);
						times++;
						delay = 3f;
				} else {
						delay -= Time.deltaTime;
				}	
	}
	void makeThing(Transform pos){
		Instantiate (thing, pos.position, Quaternion.identity);
		//GameObject [] things = GameObject.FindGameObjectsWithTag ("throwing");
	}
}
	