using UnityEngine;
using System.Collections;

public class Girls : MonoBehaviour {

	// Use this for initialization
	private int enable;
	float delay=0f;
//	public bool shootable;
	void Start () {
		enable = ControllGirl.enable;
	}

	// Update is called once per frame
	void Update () {
		/*	*/
		int gs = (int) Random.Range (0f, enable + 0.9999f);
		//Debug.Log (""+gs.ToString());
		if (delay <= 0) {
			this.transform.GetChild (gs).gameObject.SendMessage ("Throws");
			delay=0.5f;	
			}else 
						delay -= Time.deltaTime;
	}



}
