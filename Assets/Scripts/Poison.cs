using UnityEngine;
using System.Collections;

public class Poison : MonoBehaviour {

	// Use this for initialization
	float y_velo;
	bool enable;
	bool throwing;
	void Start () {
		//ThrowingStuff.shoot = true;
		//ThrowingStuff.delay = 3f;
		this.renderer.enabled = false;
		this.collider2D.enabled = false;
		throwing = false;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (throwing) {

			y_velo -= 8.2f * Time.fixedDeltaTime;
			this.transform.Translate (Vector3.up * y_velo * Time.fixedDeltaTime);
		}
	}
	void isthrowing(){
		throwing = true;
		this.renderer.enabled=true;
		this.collider2D.enabled=true;
		GameObject p = GameObject.FindGameObjectWithTag("MP");
		y_velo = Equation.equations(this.transform.position.x,
		                            this.transform.position.y,
		                            3f,
		                            p.transform.position,
		                            3);
	}

}
 