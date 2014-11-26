using UnityEngine;
using System.Collections;

public class RespawningScript : MonoBehaviour {
	public GameObject girls; 
	private float delay;
	public GameObject pc;
	public GameObject throwing;
	// Use this for initialization
	private int times;
	void Start () {
		delay = 3f;
		times = 1;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dis = new Vector3 (12*times, 0, 0);
		//Vector3 dis1 = new Vector3 (5.931374f*times, 0, 0);
		if (delay <= 0) {
						Instantiate (girls,girls.transform.position+dis , Quaternion.identity);
						Instantiate (throwing,throwing.transform.position+dis , Quaternion.identity);
						times++;
						delay = 3f;
				} else {
						delay -= Time.deltaTime;
				}	
	}
}
	