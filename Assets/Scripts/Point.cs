using UnityEngine;
using System.Collections;

public class Point : MonoBehaviour {

	// Use this for initialization

	public static float point;
	public float rateOfChange;
	public static int level;
	private float changeLevel;
	public float rateOCL;
	public static bool [] girl1={true,false,false,false};
	// Update is called once per frame
	void Awake(){
				
		}
	void Start(){
		point = 0;
		changeLevel=100;
		//rateOCL = 20;
		level = 0;

	}
	void Update () {
		point += rateOfChange * Time.deltaTime*10;
		updategirl ();
		if (point >= changeLevel) {
						level++;
						changeLevel += 100*rateOCL;
						rateOCL++;
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
		default:
			break;
			
		}
	}
	void OnGUI(){
		int t = (int)point;
		Rect pointbox = new Rect (Screen.width/2-40f, 0f, 80f, 20f);
				GUI.Box(pointbox, "" + t.ToString ());
				Rect levelbox = new Rect (0f, 0f, 80f, 20f);
				GUI.Box(levelbox, "" + level.ToString ());
		}
}
