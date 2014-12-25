using UnityEngine;
using System.Collections;

public class Throwing : MonoBehaviour {
	// Use this for initialization
	bool shooting=false;
	Vector3 p;
	float y;
	float x;
	int index=0;
	float y_velo;
	float x_velo;
	Vector3 t = new Vector3 (0,0,0);
	float timing=0f;
	void Awake() {
		y_velo = -7.5f-Point.level*0.4f;

	}
	void Start () {
		y = this.transform.position.y;
		x = this.transform.position.x;
		this.renderer.enabled = false;


	}
	
	// Update is called once per frame
	void FixedUpdate(){
		if (shooting) {
					timing+=Time.fixedDeltaTime;
					t = (Vector3.right*x_velo+Vector3.up*y_velo)*Time.fixedDeltaTime;
					this.transform.Translate (t);
				}

	}
	void isthrowing(){
				if (!shooting) {
						this.shooting = true;
						this.renderer.enabled = true;	
						GameObject pl = GameObject.FindGameObjectWithTag ("MP");
						p = pl.transform.position;
						x_velo = Equation.equations (x, y, y_velo, p, index) + 3f;
						ThrowingStuff.shoot=true;
				}


		}


	void OnTriggerEnter2D(Collider2D col) {
		if ((col.tag == "Player")||(col.tag == "ground")) {
					//	Debug.Log ("Throwing " + timing.ToString ());
						ThrowingStuff.shoot = false;
						Destroy (this.gameObject);
				}

	 
	}
}
	