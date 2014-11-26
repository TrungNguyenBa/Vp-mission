using UnityEngine;
using System.Collections;

public class Girls : MonoBehaviour {
	public static bool [] girl1={false,true,false,true,false,false,false,false};
	// Use this for initialization
	static public bool shoot=false;
	static public float delay=0.4f;
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		/*	*/
		updategirl ();
		if (shoot) {
			if (delay > 0) {
				delay -= Time.deltaTime;
			} else {
				delay = 0.4f;
				shoot = false;
			}
		}
	}
	void updategirl(){
		switch (Point.level) {
		case 0:
		{
			break;
		}
		case 1:
		{
			girl1[2] = true;
			break;
		}
		case 2:
		{
			girl1[1] = true;
			break;
		}
		case 3:
		{
			girl1[3] = true;
			break;
		}
		case 4:
		{
			girl1[4]= true;
			girl1[7]=true;
			break;
		}
		case 5:
		{
			girl1[5]=true;
			girl1[6]=true;
			break;
		}
		default:
			break;
			
		}
	}
}
