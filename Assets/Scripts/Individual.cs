using UnityEngine;
using System.Collections;

public class Individual : MonoBehaviour {

	public int index;
	public int typeIndex;
//	private bool isEnabled;
	private Transform parent;
	GameObject re;
	bool ava = true;
	private float delay=1f;
	void Awake(){
		//isEnabled = ControllGirl.girl1[index];
	}
	// Use this for initialization
	void Start () {
		//Debug.Log (.girl1 [index].ToString ());
		//if (isEnabled) {
		//	renderer.enabled = true;
			re = GameObject.FindGameObjectWithTag("Respawn");					
		//	Debug.Log(re.ToString());
	//	} else {
	//		renderer.enabled=false;
	//	}
	}
	void Update() {
		if (ava == false) {
						delay -= Time.deltaTime;
				}
		if (delay <= 0) {
						ava=true;
						setDelay (1f);
				}
	}
	void setDelay(float x) {
			delay = x;
		}
	void Throws(){
		bool t = isShootable ();
		if (t){
						re.SendMessage("setindex",this.typeIndex);
						re.SendMessage ("makeThing", this.transform);
						//ava=false;
				}
				

		
	}
	bool isShootable(){
		GameObject p = GameObject.FindGameObjectWithTag ("MP"); 
		float t = this.transform.position.x - p.transform.position.x;
		if ((t < 19) && (t > -13)&&ava) {
			return true;
		} else {
			return false;
		}
	}
}
