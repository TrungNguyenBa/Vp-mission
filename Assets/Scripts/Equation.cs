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
			
								float k = (float)(avelo*avelo) + 2f * 8.2f * (y - p.y);
								float time = ((-1*(float)avelo) - Mathf.Sqrt (k)) / (-8.2f);
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
								velo = ((p.y-y)+4.2f*(time)*time)/time;
								break;
						}
				}
		return velo;
	}
		
}
