using UnityEngine;
using System.Collections;

public class Throwing : MonoBehaviour {
	// Use this for initialization
	bool shooting=false;
	Vector3 p;
	float y;

	float x;
	public int index;
	float y_velo;
	float current_y;
	float x_velo;
	Vector3 t = new Vector3 (0,0,0);
	void Awake() {
		if (index == 1) {
						y_velo = 8f;
				} else if (index == 0) {
						y_velo = -8f;
				} else if (index == 2) {
						y_velo=-9.5f;		
		}
				

	}
	void Start () {
		y = this.transform.position.y;
		x = this.transform.position.x;
		this.renderer.enabled = false;


	}
	
	// Update is called once per frame
	void FixedUpdate(){


		if (shooting) {

						if (index == 1) {
								t = Vector3.up * current_y * Time.fixedDeltaTime;
								current_y -= 8.2f * Time.fixedDeltaTime;
								t += Vector3.right*x_velo*Time.fixedDeltaTime;		
								
						} else {
								t = (Vector3.right*x_velo+Vector3.up*y_velo)*Time.fixedDeltaTime;
								
						}
						this.transform.Translate (t);
				}

	}
	void isthrowing(){
			if(shooting==false){
					ThrowingStuff.shoot=true;	
					shooting = true;
			this.renderer.enabled=true;	
			current_y = y_velo;
			GameObject pl = GameObject.FindGameObjectWithTag ("MP");
			p = pl.transform.position;
			x_velo=Equation.equations(x,y,y_velo,p,index)+2.83f;
			if (index==1) {
				ThrowingStuff.delay=2.6f-Point.level*0.05f;
			}


		}
				
				// keep going;			
		//this.transform.Translate(new Vector3(1f*Time.deltaTime,-1f*Time.deltaTime,0))
			//else 


			
	}
	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Player") {
			//Debug.Log("hit");
			Destroy(this.gameObject);
		}
	}
}
