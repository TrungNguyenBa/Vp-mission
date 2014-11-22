using UnityEngine;
using System.Collections;

public class Girls : MonoBehaviour {
	public static bool [] girl1={true,false,false,false};
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		/*	*/
		updategirl ();
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
		default:
			break;
			
		}
	}
}
