using UnityEngine;
using System.Collections;

public class Equation : MonoBehaviour {
		
	public static float equations (float x, float y, float avelo, Vector3 p,int index) {
		//Vector3 t = new Vector3();
		float velo=0;
		switch (index) {
				case 0:
						{
								velo = (p.x - x) * (-1*avelo) / (y - p.y);
								break;	
						}

				case 1:
						{
								float a =(8.2f+Point.level*0.4f) ;			
								float k = (avelo*avelo) + 2f *a * (y - p.y);
								float time = ((-1*avelo) - Mathf.Sqrt (k)) / (-a);
			 					velo = (p.x-x+0.3f)/ time;
								break;
						}
				case 2:
						{
								velo = (p.x-x) * (-1*avelo) / (y - p.y);
								break;	
						}
				case 3: {
								float dis = x-p.x;
								float time = dis/avelo;
								velo = ((p.y-y)+(4.2f+Point.level*0.3f)*time*time)/time;
								break;
						}
				}
		return velo;
	}
		
}
