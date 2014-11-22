using UnityEngine;
using System.Collections;

public class RespawningScript : MonoBehaviour {
	public GameObject girls; 
	private float delay;
	public GameObject player;
	// Use this for initialization
	private int times;
	void Start () {
		delay = 3f;
		times = 1;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dis = new Vector3 (3.919564f*times, girls.transform.position.y-player.transform.position.y, 0);
		if (delay <= 0) {
						Instantiate (girls, player.transform.position + dis, Quaternion.identity);
						times++;
						delay = 3f;
				} else {
						delay -= Time.deltaTime;
				}
	}
}
