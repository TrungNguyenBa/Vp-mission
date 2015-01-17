using UnityEngine;
using System.Collections;

public class Bouncing : MonoBehaviour {

	// Use this for initialization
	bool shooting=false;
	Vector3 p;
	float y;
	float x;
	GameObject girl = null;
	int index;
	bool ar = false;
	float y_velo;
	float x_velo;
	bool touch_bag = false;
	float bar;
	Vector3 t = new Vector3 (0,0,0);
	void Awake() {
		index = 2;
		y_velo = -9f-Point.level*0.3f;
		
	}
	void Start () {
		y = this.transform.position.y;
		x = this.transform.position.x;
		this.renderer.enabled = false;
		
		
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		if ((this.transform.position.y >= -2.160214f)&&(y_velo>0)) {
			if (ThrowingStuff.during==false) {
				ThrowingStuff.shoot = false;
			}
			Destroy(this.gameObject);
		}
		if (shooting) {
			t = (Vector3.right*x_velo+Vector3.up*y_velo)*Time.fixedDeltaTime;
			this.transform.Translate (t);
		}
		
	}
	void isthrowing(){
		GameObject pl = GameObject.FindGameObjectWithTag ("MP");
		float dis = this.transform.position.x -pl.transform.position.x;
		if ((!shooting)&&(dis>-6)&&(dis<10)) {
			ThrowingStuff.shoot=true;
			this.shooting = true;
			this.renderer.enabled = true;	
			p = pl.transform.position;
			girl.SendMessage("change_throw");
			ar=true;
			x_velo = Equation.equations (x, y, y_velo, p, index) + 3f;
		}
		
		
	}
	void setgirl(GameObject a) {
		girl = a;
	}
	void OnTriggerEnter2D(Collider2D col) {
		if ((col.tag=="Player")&&(!touch_bag)) {
			Destroy(this.gameObject);
			Point.GAMEOVER();
		} else if (col.tag == "ground") {
			y = this.transform.position.y;
			x = this.transform.position.x;
			y_velo = 9f;
			GameObject pl = GameObject.FindGameObjectWithTag ("MP");
			float dis = this.transform.position.x - pl.transform.position.x;
			p = pl.transform.position;
			x_velo = Equation.equations (x, y, y_velo, p, index) + 3f;
		} else if (col.tag == "Bag") {
				if (col.tag == "Bag") {
				touch_bag=true;
				this.renderer.enabled=false;
		}
	}



	}
}
