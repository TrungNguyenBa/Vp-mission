using UnityEngine;
using System.Collections;

public class Individual : MonoBehaviour {

	public int index;
	int typeIndex;
	private Transform parent;
	GameObject re;
	public Sprite []sp;
	int n;
	public bool pa;
	bool flip = false;
	bool ava = true;
	private float delay=1f;
	float de=0.5f;
	bool ischange=false;
	void Awake(){
		typeIndex = Random.Range (0, 3);
		if ((!pa)&&(typeIndex==1)) {
			typeIndex=0;			
		}
		if (typeIndex == 0) {
			n = 8;
							
		} else if (typeIndex == 1) {
			n = 0;

		} else {
			n = 4;
			 
		}
		this.GetComponent<SpriteRenderer>().sprite = sp[n];
			
	}
	// Use this for initialization
	void Start () {
		re = GameObject.FindGameObjectWithTag("Respawn");					

	}
	void Update() {
		GameObject pl = GameObject.FindGameObjectWithTag ("MP");
		if (ischange) {
			if (de <= 0) {
				ischange=false;
				this.GetComponent<SpriteRenderer>().sprite = sp[n];
				de=0.5f;
			}
			else {
				de-=Time.deltaTime;
			}
				}
		if (((pl.transform.position.x - this.transform.position.x) > 0.5)&&(!flip)&&(!ischange)) {
			n +=2;
			flip = true;
			this.GetComponent<SpriteRenderer>().sprite = sp[n];
		}
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
						ava=false;
				}
				

		
	}
	void change_throw() {
		this.GetComponent<SpriteRenderer> ().sprite = sp [n + 1];
		ischange = true;
	}
	bool isShootable(){
		GameObject p = GameObject.FindGameObjectWithTag ("MP"); 
		float t = this.transform.position.x - p.transform.position.x;
		if ((t < 15)&&ava) {
			return true;
		} else {
			return false;
		}
	}
}
