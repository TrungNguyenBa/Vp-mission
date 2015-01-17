using UnityEngine;
using System.Collections;

public class Parabol : MonoBehaviour {
	bool shooting;
	float x_velo;
	Vector3 p;
	float y_velo;
	float y;
	int index = 1;
	float x;
	float bar;
	int n =0;
	bool touch_bag = false;
	GameObject girl;
	float timing=0f;
	// Use this for initialization
	void Start () {
		y_velo = 8f;
		shooting = false;
		y = this.transform.position.y;
		x = this.transform.position.x;
		this.renderer.enabled = false;
		if (Point.level < 10) {
			bar = -1.660214f + Point.level*0.02f;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if ((this.transform.position.y >= 6.5) && (y_velo >= 0) && (n == 0)) {
			n++;
			ThrowingStuff.shoot=false;
			ThrowingStuff.during=true;
		}
		if ((this.transform.position.y <= bar)&&(n==1)) {
			++n;
			ThrowingStuff.shoot = false;		
			ThrowingStuff.during=false;
		}
		if (shooting) {
			timing+=Time.fixedDeltaTime;
			y_velo -= 8.2f * Time.fixedDeltaTime;
			Vector3 t = (Vector3.right*x_velo+Vector3.up*y_velo)*Time.fixedDeltaTime;		
			transform.Translate(t);
		}
			
	}
	void isthrowing(){
		GameObject pl = GameObject.FindGameObjectWithTag ("MP");
		float dis = this.transform.position.x -pl.transform.position.x;
		if ((!shooting)&&(dis>-8)&&(dis<10)&&(!ThrowingStuff.during)) {		
						this.shooting = true;
						this.renderer.enabled = true;	
						p = pl.transform.position;
						x_velo = Equation.equations (x, y, y_velo, p, index) + 3f;
						girl.SendMessage("change_throw");
						ThrowingStuff.shoot=true;

				}
		}
	void setgirl(GameObject a) {
		girl = a;
	}
	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Player") {
						//Debug.Log ("Parabol " + timing.ToString ());
						Destroy (this.gameObject);
				} 
		if (col.tag == "Bag") {
			touch_bag=true;
			this.renderer.enabled=false;

		}
		
		
	}

}