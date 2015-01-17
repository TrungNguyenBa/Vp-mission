using UnityEngine;
using System.Collections;

public class KissingGirl : MonoBehaviour {

	// Use this for initialization
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
			throwing=true;
			this.transform.GetChild(0).SendMessage("isthrowing");
			this.GetComponent<SpriteRenderer>().sprite = sp[n+1];
			delay=1f;

		}
		if (delay<0) {
			this.GetComponent<SpriteRenderer>().sprite = sp[n];
		}
		else {
			delay-=Time.deltaTime;
		}
	}
}
