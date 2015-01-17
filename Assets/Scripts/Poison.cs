using UnityEngine;
using System.Collections;

public class Poison : MonoBehaviour {

	// Use this for initialization
	float y_velo;
	bool enable;
	bool touch_bag=false;
	float bar;
	bool throwing;
	int n = 0;
	void Start () {
		//ThrowingStuff.shoot = true;
		//ThrowingStuff.delay = 3f;
		this.renderer.enabled = false;
		this.collider2D.enabled = false;
		y_velo = 0;
		throwing = false;
		if (Point.level < 10) {
			bar = -1.4f + Point.level*0.03f;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if ((this.transform.position.y <= bar)&&(n==0)&&(y_velo<0)) {
			n++;
			if (ThrowingStuff.during==false) {
				ThrowingStuff.shoot = false;
			}		
		}
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
		                            2.7f,
		                            p.transform.position,
		                            3);
		//Debug.Log (ThrowingStuff.shoot.ToString());
	}
	void OnTriggerEnter2D(Collider2D col) {
		if ((col.tag=="Player")&&(!touch_bag)) {
			Destroy(this.gameObject);
			Point.GAMEOVER();
		}
		if (col.tag == "Bag") {
			touch_bag=true;
			this.renderer.enabled=false;
			
		}
	}

}
 