using UnityEngine;
using System.Collections;

public class Destroys : MonoBehaviour {
	public Transform player;
	public float dis;
	// Update is called once per frame

	void Update () {
		this.transform.position = new Vector3 (player.position.x-dis,
		                                     this.transform.position.y,
		                                     this.transform.position.z);
	
	}
	void OnTriggerEnter2D(Collider2D col){

		if ((col.gameObject.tag != "Destroy")&&(col.gameObject.tag != "Player")) {
		
			Destroy(col.gameObject);
				}
		}

}
