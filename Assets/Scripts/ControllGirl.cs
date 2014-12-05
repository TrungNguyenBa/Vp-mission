using UnityEngine;
using System.Collections;

public class ControllGirl : MonoBehaviour {
//	public static bool [] girl1={true,false,false,true,false,false,false,false};
	// Use this for initialization
	public static int enable=7;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//			updategirl ();
	}
/*	void updategirl(){
		switch (Point.level) {
		case 0:
		{
			break;
		}
		case 1:
		{
			girl1[2] = true;
			if (enable<3)
				enable++;
			break;
		}
		case 2:
		{
			girl1[1] = true;
			if (enable<4)
			enable++;
			break;
		}
		case 3:
		{
			girl1[4] = true;
			if (enable<5)
			enable++;
			break;
		}
		case 4:
		{
			//girl1[4]= true;
			girl1[7]=true;
			if (enable<6)
			enable++;
			break;
		}
		case 5:
		{
			girl1[5]=true;
			girl1[6]=true;
			if (enable<8)
			enable+=2;
			break;
		}
		default:
			break;
			
		}
	}*/
}
