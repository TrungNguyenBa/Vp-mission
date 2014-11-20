using UnityEngine;
using System.Collections;

public class CameraFollower : MonoBehaviour {

	// Use this for initialization
	public Transform player;
	public float distance;
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (player.position.x + distance,
		                                     this.transform.position.y,
		                                     this.transform.position.z);
	}
}
