using UnityEngine;
using System.Collections;

public class ThrowingStuff : MonoBehaviour {

	static public bool shoot;
	static public bool isWild;
	float delay =0f;
	float making;
	private GameObject[] things;
	private GameObject[] Wildgirls;
	// Use this for initialization
	// Update is called once per frame
	void Start(){
		isWild=false;
		shoot = false;
		making = 4f;
	}
	void Update () {
		things = GameObject.FindGameObjectsWithTag("throwing");
		Wildgirls = GameObject.FindGameObjectsWithTag ("Wild");
		if (things != null) {
						making -= Time.deltaTime ;
						if (delay <1){
							delay+=Time.deltaTime;
						}
						//Debug.Log(shoot.ToString());
						
						if ((!shoot)&&(delay>1)) {
							bool rand = (Random.Range(0,5)>=3)&&(Point.level>1)&&(making<0);
							Debug.Log(making.ToString());
							
							if (rand) {
									GameObject re = GameObject.FindGameObjectWithTag("Respawn");
									re.SendMessage("createChem");
									making =4f;
									
							}
							else {
									if (Wildgirls!=null) {
										for (int i=0;i<Wildgirls.Length;i++) {
											Wildgirls[i].SendMessage("checkforjump");
											if (isWild) {
												break;
											}	
										}
									}
									if (isWild==false) {
										int random = (int)Random.Range (0, things.Length);
										things [random].SendMessage ("isthrowing");
									}
								}
							
						}
				}
		}


}
