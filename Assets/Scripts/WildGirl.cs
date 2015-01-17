using UnityEngine;
using System.Collections;

public class WildGirl : MonoBehaviour {

	// Use this for initialization
	float Rand;
	bool jump;
	float y_velo;
	float x_velo;
	int n =0;
	float bar;
	bool touch_bag = false;
	public Sprite[] sp; 
	void Start () {
		Rand = Random.Range (0f, 1f);
		y_velo = 3f;
		jump = false;
		if (Point.level < 10) {
						bar = -1.4f + Point.level*0.03f;
				}
	}
	// Update is called once per frame
	void FixedUpdate () {
		if ((this.transform.position.y <=bar)&&(n==0)) {
			n++;
			if (ThrowingStuff.during==false) {
				ThrowingStuff.shoot = false;
			}
			
		}
		checkforjump ();
		if (jump) {

						Vector3 t = (Vector3.right * x_velo + Vector3.up * y_velo) * Time.fixedDeltaTime;
						this.transform.Translate (t);
						y_velo -= 10.2f * Time.fixedDeltaTime;
						

				} else {
						Rand-=Time.fixedDeltaTime;
				}
	}
	void checkforjump(){
		if ((!jump)&&(Rand<=0)) {
						int t = 0 ;
						GameObject p = GameObject.FindGameObjectWithTag ("MP");
						float k = this.transform.position.x - p.transform.position.x;
						float ran = Random.Range (0, 4);
						this.jump = true;
						ThrowingStuff.shoot=true;
						x_velo = Equation.equations (this.transform.position.x,
					                             this.transform.position.y,
					                             y_velo,
					                             p.transform.position,
					                             4) + 2.8f;
						if (k <-3.5) {
							t = 2;	
						}
						else if (k >4 ) {
							t = 1;
						}
			this.GetComponent<SpriteRenderer>().sprite = sp[t];
						}
				}
				
		
	void OnTriggerEnter2D(Collider2D col) {
		if ((col.tag=="Player")&&(!touch_bag)) {
			Destroy(this.gameObject);
			Point.GAMEOVER();
		}
		if (col.tag == "Bag") {
			touch_bag=true;
			this.renderer.enabled=false;
				}
		}
}

