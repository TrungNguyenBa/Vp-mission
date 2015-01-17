using UnityEngine;
using System.Collections;

public class Ksss : MonoBehaviour {

	// Use this for initialization
	public float Ampitude;
	float x_velo;
	bool shoot;
	float y_velo;
	GameObject pl;
	float time=0;
	int n=0;
	void Start() {
		shoot = false;
		this.renderer.enabled=false;
		this.collider2D.enabled=false;
		x_velo = -5f - Point.level * 0.05f;
	}
	// Update is called once per frame
	void FixedUpdate () {
				pl = GameObject.FindGameObjectWithTag ("MP");
				float dis = this.transform.position.x - pl.transform.position.x;
				if (shoot) {
						time += Time.fixedDeltaTime;
						//Debug.Log(Mathf.Sin(time).ToString());
						y_velo = 2 * Ampitude * Mathf.Cos (2 * time);
						this.transform.Translate ((Vector3.up * y_velo + x_velo* Vector3.right) * Time.fixedDeltaTime);
						
				}
				if ((dis <= -4)&&(n==0)) {
						n++;
						ThrowingStuff.shoot = false;
				}
				
		}

	void isthrowing() {
		shoot = true;
		this.renderer.enabled=true;
		this.collider2D.enabled=true;

	}
	void OnTriggerEnter2D(Collider2D col) {
		if ((col.tag == "Player")) {
			Destroy (this.gameObject);
			Point.GAMEOVER();
		} 

	}
}
