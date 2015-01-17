using UnityEngine;
using System.Collections;
public class Throwing : MonoBehaviour {
	// Use this for initialization
	bool shooting=false;
	Vector3 p;
	float y;
	float x;
	GameObject girl;
	int index=0;
	float y_velo;
	float x_velo;
	float bar;
	bool touch_bag=false;
	Vector3 t = new Vector3 (0,0,0);
	float timing=0f;
	void Awake() {
		y_velo = -7.0f-Point.level*0.5f;
	}
	void Start () {
		y = this.transform.position.y;
		x = this.transform.position.x;
		this.renderer.enabled = false;
	}
	// Update is called once per frame
	void FixedUpdate(){
		if (shooting) {
					Debug.Log(girl.ToString());
					timing+=Time.fixedDeltaTime;
					t = (Vector3.right*x_velo+Vector3.up*y_velo)*Time.fixedDeltaTime;
					this.transform.Translate (t);
				}
	}
	void setgirl(GameObject a) {
		girl = a;
	}
	void isthrowing(){
				GameObject pl = GameObject.FindGameObjectWithTag ("MP");
				float dis = this.transform.position.x -pl.transform.position.x;
				if ((!shooting)&&(dis>-5)&&(dis<10)) {
						this.shooting = true;
						this.renderer.enabled = true;	
						p = pl.transform.position;
						x_velo = Equation.equations (x, y, y_velo, p, index) + 3f;
						girl.SendMessage("change_throw");
						ThrowingStuff.shoot=true;
				}
		}
	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "ground") {
					//	Debug.Log ("Throwing " + timing.ToString ());
						if (ThrowingStuff.during==false) {
							ThrowingStuff.shoot = false;
						}
		}
		if ((col.tag=="Player")&&(!touch_bag)) {
			Destroy(this.gameObject);
			Point.GAMEOVER();
		}
		if (col.tag == "Bag") {
			touch_bag = true;
			this.renderer.enabled = false;
		}

	 
	}
}
	