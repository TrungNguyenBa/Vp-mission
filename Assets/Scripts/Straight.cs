using UnityEngine;
using System.Collections;

public class Straight : MonoBehaviour  {

	// Use this for initialization
	public Sprite [] sp;
	
	// Update is called once per frame
	void Update () {
		if (Player.isStraight) {
			this.renderer.enabled=true;	
			this.collider2D.enabled=true;
		} else {
			this.renderer.enabled=false;
			this.collider2D.enabled=false;
				}
	}
}
