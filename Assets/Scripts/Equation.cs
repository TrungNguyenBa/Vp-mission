using UnityEngine;
using System.Collections;

public class Equation : MonoBehaviour {
	static float x_velo;
	public static Vector3 equations (float x, float y, int y_velo, Vector3 p,int index) {
		Vector3 t = new Vector3();
		switch (index) {
				case 0:
						{
								x_velo = (p.x - x + 0.8f) * (~y_velo + 1) / (y - p.y);

								t = Vector3.right * ((x_velo + 0.6f) * Time.deltaTime) + Vector3.up * (y_velo * Time.deltaTime);
								break;	
						}

				case 1:
						{
							
								break;
						}
				case 2:
						{
								y_velo=y_velo+5;
								x_velo = (p.x - x + 0.8f) * (~y_velo + 1) / (y - p.y);
			
								t = Vector3.right * ((x_velo + 0.6f) * Time.deltaTime) + Vector3.up * (y_velo * Time.deltaTime);

								break;	
						}
				}
		return t;
	}
		
}
