using UnityEngine;
using System.Collections;

public class Individual : MonoBehaviour {

	public int index;
	private bool isEnabled;
	float delay=0f;
	float lucky;
	void Awake(){
		isEnabled = Girls.girl1[index];
	}
	// Use this for initialization
	void Start () {
		//Debug.Log (.girl1 [index].ToString ());
		if (isEnabled) {
			renderer.enabled = true;
			if ((!Girls.shoot)&&(delay==0)){
				lucky = Random.Range(0f,2f);
				if (lucky >1){
					Girls.shoot=true;
					delay=1f;
				}
				else{
					delay=0.1f;
				}
			}
			else if (delay <0) {
				delay=0;
				
			}
			else if (delay>0) {
				delay-=Time.deltaTime;
			}

		} else {
			renderer.enabled=false;
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
