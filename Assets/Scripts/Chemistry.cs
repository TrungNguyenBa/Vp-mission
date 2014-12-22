using UnityEngine;
using System.Collections;

public class Chemistry : MonoBehaviour {
	bool throwing;
	GameObject re;
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
			if (dis<7) {
				throwing=true;
				this.transform.GetChild(0).SendMessage("isthrowing");
			}
		}
	}
}
