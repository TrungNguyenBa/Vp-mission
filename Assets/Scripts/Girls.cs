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
				enable = this.transform.childCount;
				int gs = (int)Random.Range (0f, enable);
				if ((delay <= 0)&&(enable>0)) {
						Transform t = this.transform.GetChild (gs);
						if ((t.gameObject != null)&&(t.gameObject.tag!="Wild")) {
								t.gameObject.SendMessage ("Throws");
								delay = 0.5f;	
						} 
				}
				else {
								delay -= Time.deltaTime;
						
			
			}
				
		}



}
