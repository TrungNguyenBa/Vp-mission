using UnityEngine;
using System.Collections;

public class ThrowingStuff : MonoBehaviour {

	static public bool shoot=true;
	static public float delay=1f;
	static public float standard;
	static public bool isWild;
	float makingdelay =0f;
	private GameObject[] things;
	private GameObject[] Wildgirls;
	// Use this for initialization
	// Update is called once per frame
	void Start(){
		isWild=false;

	}
	void Update () {
		things = GameObject.FindGameObjectsWithTag("throwing");
			//Debug.Log (delay.ToString());
		Wildgirls = GameObject.FindGameObjectsWithTag ("Wild");
		if (things != null) {
						if (shoot) {
								if (delay > 0) {
										delay -= Time.fixedDeltaTime;
										makingdelay-=Time.fixedDeltaTime;	
										Debug.Log(delay.ToString());
								} else {
										shoot = false;
										isWild=false;
								}
							} else {
								int rand = Random.Range(0,4);
								if ((Point.level>1)&&(rand>=2)&&(makingdelay<=0)) {
									GameObject re = GameObject.FindGameObjectWithTag("Respawn");
									GameObject pl = GameObject.FindGameObjectWithTag("MP");
									if (rand==2) {
										re.SendMessage("createChem");
									}
									else if (rand==3) {
										re.SendMessage("createKss");
									}
									Delays(3);
									makingdelay =4f;
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
									//Debug.Log(isWild.ToString());
									if (isWild==false) {
									int random = (int)Random.Range (0, things.Length);
									things [random].SendMessage ("isthrowing");
									}
								}
						}
				}

	}
	public static void Delays(int index) {
				switch (index) {
				case 0:
						{
								standard = 0.6f;
								break;
						}
				case 1:
						{
								standard = 0.6f;
								break;
						}
				case 2:
						{
								standard = 0.6f;
								break;
						}
				case 3:
						{
								standard = 2.0f;
								break;
						}
				case 4: {
								standard = 2.0f;
								break;
						}
				}
				delay = standard;
				shoot = true;
	}
}
