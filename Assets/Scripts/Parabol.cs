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
	float timing=0f;
	// Use this for initialization
	void Start () {
		y_velo = 8f;
		shooting = false;
		y = this.transform.position.y;
		x = this.transform.position.x;
		this.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (shooting) {
			timing+=Time.fixedDeltaTime;
			y_velo -= 8.2f * Time.fixedDeltaTime;
			Vector3 t = (Vector3.right*x_velo+Vector3.up*y_velo)*Time.fixedDeltaTime;		
			transform.Translate(t);
		}
			
	}
	void isthrowing(){
				if (!shooting) {
						this.shooting = true;
						this.renderer.enabled = true;	
						GameObject pl = GameObject.FindGameObjectWithTag ("MP");
						p = pl.transform.position;
						x_velo = Equation.equations (x, y, y_velo, p, index) + 2.83f;
						ThrowingStuff.shoot=true;

				}
		}
	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Player") {
						//Debug.Log ("Parabol " + timing.ToString ());
						Destroy (this.gameObject);
				} else if (col.gameObject.tag == "Trigger") {
						
						ThrowingStuff.shoot=false;
					//		Debug.Log("here");
				}
		}
		
		
	}

