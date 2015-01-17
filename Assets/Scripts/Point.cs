using UnityEngine;
using System.Collections;

public class Point : MonoBehaviour {

	// Use this for initialization

	public static float point;
	public float rateOfChange;
	public static int level;
	private float changeLevel;
	public float rateOCL;
	// Update is called once per frame
	void Start(){
		point = 0;
		changeLevel=100;
		//rateOCL = 20;
		level = 0;

	}
	void Update () {
		point += rateOfChange * Time.deltaTime*10;

		if (point >= changeLevel) {
						level++;
						changeLevel += 100*rateOCL;
						rateOCL++;
				}

	}
	public static void GAMEOVER() {
		Time.timeScale = 0;
	}
	void OnGUI(){
		int t = (int)point;
		Rect pointbox = new Rect (Screen.width/2-40f, 0f, 80f, 20f);
				GUI.Box(pointbox, "" + t.ToString ());
				Rect levelbox = new Rect (0f, 0f, 80f, 20f);
				GUI.Box(levelbox, "" + level.ToString ());
		}
}
