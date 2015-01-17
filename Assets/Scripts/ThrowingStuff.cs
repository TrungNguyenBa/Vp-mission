using UnityEngine;
using System.Collections;

public class ThrowingStuff : MonoBehaviour {

	static public bool shoot;
	float delay =0f;
	float making;
	float r;
	static public bool during=false;
	private GameObject[] things;
	private GameObject[] Wildgirls;
	// Use this for initialization
	void Start(){
		shoot = false;
		making = Random.Range(4f,8f);
		r = Random.Range (0f, 4f);
	}
	void Update () {
		things = GameObject.FindGameObjectsWithTag("throwing");
		Wildgirls = GameObject.FindGameObjectsWithTag ("Wild");
		making -= Time.deltaTime ;
		r -= Time.deltaTime;
		if (things.Length>0) {
						if (delay <2.3){
							delay+=Time.deltaTime;
						}
						if ((!shoot)&&(delay>1)) {
							bool rand = (Point.level>1)&&(making<0)&&(!during);
							GameObject re = GameObject.FindGameObjectWithTag("Respawn");
							if (rand) {
									bool ra = (Random.Range(0,4)>2);
									if (!ra) {
										re.SendMessage("createChem");
									}
									else {
										re.SendMessage("createKss");
									}
									making =Random.Range(4f,8f);
							}
								
							else {
									if ((r<0)&&(Point.level>1)&&(!during)) {
										re.SendMessage("createWild");
										r = Random.Range (10f, 25f);
									}
									else {
										int random = (int)Random.Range (0, things.Length);
										things [random].SendMessage ("isthrowing");
									}
								}
							
						}
				}
		}


}
