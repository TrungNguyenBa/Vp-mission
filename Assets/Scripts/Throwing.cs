using UnityEngine;
using System.Collections;

public class Throwing : MonoBehaviour {
	// Use this for initialization
	bool shooting=false;
	Vector3 p;
	float y;
	int y_velo=-10;
	float x;
	void Start () {
		y = this.transform.position.y;
		x = this.transform.position.x;
		this.renderer.enabled = false;


	}
	
	// Update is called once per frame
	void Update(){
		GameObject pl = GameObject.FindGameObjectWithTag ("MP");
		p = pl.transform.position;

		if (shooting) {
			Vector3 t = Equation.equations(x,y,y_velo,p,0);
			this.transform.Translate(t);		
		}

	}
	void isthrowing(){
			if(shooting==false){
					ThrowingStuff.shoot=true;	
					shooting = true;
			this.renderer.enabled=true;	
			}
				
				// keep going;			
		//this.transform.Translate(new Vector3(1f*Time.deltaTime,-1f*Time.deltaTime,0))
			//else 


			
	}
	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Player") {
			Debug.Log("hit");		
		}
	}
}
