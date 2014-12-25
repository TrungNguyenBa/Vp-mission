using UnityEngine;
using System.Collections;

public class Bouncing : MonoBehaviour {

	// Use this for initialization
	bool shooting=false;
	Vector3 p;
	float y;
	float x;
	int index;
	float y_velo;
	float x_velo;
	Vector3 t = new Vector3 (0,0,0);
	void Awake() {
		index = 2;
		y_velo = -9.375f-Point.level*0.3f;
		
	}
	void Start () {
		y = this.transform.position.y;
		x = this.transform.position.x;
		this.renderer.enabled = false;
		
		
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		if (shooting) {
			t = (Vector3.right*x_velo+Vector3.up*y_velo)*Time.fixedDeltaTime;
			this.transform.Translate (t);
		}
		
	}
	void isthrowing(){
		if (!shooting) {
			ThrowingStuff.shoot=true;
			this.shooting = true;
			this.renderer.enabled = true;	
			GameObject pl = GameObject.FindGameObjectWithTag ("MP");
			p = pl.transform.position;
			x_velo = Equation.equations (x, y, y_velo, p, index) + 2.83f;
		}
		
		
	}
	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Player") {
			Debug.Log("hit");

		}
		else if (col.tag == "ground") {
			shooting =false;
			y = this.transform.position.y;
			x = this.transform.position.x;
			y_velo=3f;
			isthrowing();
		}
		else if ((col.tag == "Trigger")&&(y_velo>0)) {
			ThrowingStuff.shoot=false;
			Destroy(this.gameObject);
		}

	}
}
