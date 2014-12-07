using UnityEngine;
using System.Collections;

public class Equation : MonoBehaviour {
		
	public static float equations (float x, float y, float y_velo, Vector3 p,int index) {
		//Vector3 t = new Vector3();
		float x_velo=0;
		switch (index) {
				case 0:
						{
								x_velo = (p.x - x) * (-1*y_velo) / (y - p.y);

				//				t = Vector3.right * ((x_velo + 0.6f) * Time.deltaTime) + Vector3.up * (y_velo * Time.deltaTime);
								break;	
						}

				case 1:
						{
			
								float k = (float)(y_velo*y_velo) + 2f * 8.2f * (y - p.y);
								float time = ((-1*(float)y_velo) - Mathf.Sqrt (k)) / (-8.2f);
			 					x_velo = (p.x-x+0.3f)/ time;
				//				t = Vector3.right*(x_velo)*Time.deltaTime;
								break;
						}
				case 2:
						{
								x_velo = (p.x-x) * (-1*y_velo) / (y - p.y);
			
				//				t = Vector3.right * ((x_velo + 0.6f) * Time.deltaTime) + Vector3.up * (y_velo * Time.deltaTime);

								break;	
						}
				}
		return x_velo;
	}
		
}
