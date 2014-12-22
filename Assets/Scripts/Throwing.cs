﻿using UnityEngine;
using System.Collections;

public class Throwing : MonoBehaviour {
	// Use this for initialization
	bool shooting=false;
	Vector3 p;
	float y;
	float x;
	public int index;
	float y_velo;
	float x_velo;
	Vector3 t = new Vector3 (0,0,0);
	void Awake() {
		if (index == 1) {
						y_velo = 12.0f;
				} else if (index == 0) {
						y_velo = -9.375f;
				} else if (index == 2) {
						y_velo=-9.375f;		
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
								y_velo -= 8.2f * Time.fixedDeltaTime;
								t = (Vector3.right*x_velo+Vector3.up*y_velo)*Time.fixedDeltaTime;
						} else {
								
								t = (Vector3.right*x_velo+Vector3.up*y_velo)*Time.fixedDeltaTime;
						}
						this.transform.Translate (t);
				}

	}
	void isthrowing(){
				if (!shooting) {
						this.shooting = true;
						this.renderer.enabled = true;	
						GameObject pl = GameObject.FindGameObjectWithTag ("MP");
						p = pl.transform.position;
						x_velo = Equation.equations (x, y, y_velo, p, index) + 2.83f;
						ThrowingStuff.Delays(index);
				}


		}


	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Player") {
			//Debug.Log("hit");
			Destroy(this.gameObject);
		}
	}
}
