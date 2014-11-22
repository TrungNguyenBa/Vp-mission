using UnityEngine;
using System.Collections;

public class Girls : MonoBehaviour {
	public static bool Girl1;
	public static bool Girl2;
	public static bool Girl3;
	public static bool Girl4;
	// Use this for initialization
	void Start () {
		Girl1 = true;
		Girl2 = false;
		Girl3 = false;
		Girl4 = false;

	}
	
	// Update is called once per frame
	void Update () {
		switch (Point.level) {
				case 0:
						{
								break;
						}
				case 1:
						{
								Girl3 = true;
								break;
						}
				case 2:
						{
								Girl2 = true;
								break;
						}
				case 3:
						{
								Girl4 = true;
								break;
						}
				default:
						break;
		
				}
	}
}
