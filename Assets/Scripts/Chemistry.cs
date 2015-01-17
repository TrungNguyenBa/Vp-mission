using UnityEngine;
using System.Collections;

public class Chemistry : MonoBehaviour {
	bool throwing;
	GameObject re;
	public Sprite[] sp;
	int n =0;
	float delay=0f;
	void Awake(){
		}
	// Use this for initialization
	void Start () {
		throwing = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!throwing) {
			GameObject p = GameObject.FindGameObjectWithTag ("MP");
			float dis = this.transform.position.x - p.transform.position.x;
			if (dis<6) {
				throwing=true;
				this.transform.GetChild(0).SendMessage("isthrowing");
				this.GetComponent<SpriteRenderer>().sprite = sp[n+1];
				delay=0.5f;
			}

		}
		if (delay<0) {
			this.GetComponent<SpriteRenderer>().sprite = sp[n];
		}
		else {
			delay-=Time.deltaTime;
		}
	}
}
