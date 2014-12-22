using UnityEngine;
using System.Collections;

public class Ksss : MonoBehaviour {

	// Use this for initialization
	public float Ampitude;
	float x_velo;
	bool shoot;
	float y_velo;
	GameObject pl;
	float time=0;

	// Update is called once per frame
	void FixedUpdate () {
				pl = GameObject.FindGameObjectWithTag ("MP");
				float dis = this.transform.position.x - pl.transform.position.x;
				if (dis < 8) {
						time+=Time.fixedDeltaTime;
						//Debug.Log(Mathf.Sin(time).ToString());
						y_velo = 3*Ampitude*Mathf.Cos(3*time);
			this.transform.Translate ((Vector3.up*y_velo+-1.3f*Vector3.right)*Time.fixedDeltaTime);
				}
		}
}
