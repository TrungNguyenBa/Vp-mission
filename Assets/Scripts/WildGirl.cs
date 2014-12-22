using UnityEngine;
using System.Collections;

public class WildGirl : MonoBehaviour {

	// Use this for initialization
	bool enable;
	bool jump;
	float y_velo;
	float x_velo;

	void Awake(){
		enable = (Point.level > 1) && (Random.Range (1f, 3f) > 2);
	}
	void Start () {
		y_velo = 3f;
		if (!enable) {
			this.renderer.enabled = false;
			this.collider2D.enabled = false;
		}
		jump = false;
	}
	// Update is called once per frame
	void FixedUpdate () {
			if (jump) {
					Vector3 t = (Vector3.right*x_velo+Vector3.up*y_velo)*Time.fixedDeltaTime;
					this.transform.Translate(t);
					y_velo -= 8.2f*Time.fixedDeltaTime;ThrowingStuff.shoot=true;

		}
	}
	void checkforjump(){
		if ((enable)&&(!jump)) {
						GameObject p = GameObject.FindGameObjectWithTag ("MP");
						float k = this.transform.position.x - p.transform.position.x;
						float ran = Random.Range (0, 4);
						if (((k < 13) && (k > 10)&&(ran>2))||(k<5)) {
										this.jump = true;
										ThrowingStuff.Delays (3);
										ThrowingStuff.isWild=true;
										x_velo = Equation.equations (this.transform.position.x,
					                             this.transform.position.y,
					                             y_velo,
					                             p.transform.position,
					                             1) + 2.8f;
								
						}
				}
			
		}
	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Player") {
			//Debug.Log("hit");
			Destroy(this.gameObject);
		}
	}
}
