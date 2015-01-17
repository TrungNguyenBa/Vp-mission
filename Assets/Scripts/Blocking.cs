using UnityEngine;
using System.Collections;

public class Blocking : MonoBehaviour {

	// Use this for initialization

	// Update is called once per frame
	void Update () {

			if (Player.isBlocking) {
				this.renderer.enabled=true;	
				this.collider2D.enabled=true;
				this.GetComponentInChildren<BoxCollider2D>().enabled=true;
			} else {
				this.renderer.enabled=false;
				this.collider2D.enabled=false;
				this.GetComponentInChildren<BoxCollider2D>().enabled=false;
			}

	}
}
