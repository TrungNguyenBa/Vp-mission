using UnityEngine;
using System.Collections;

public class RespawningScript : MonoBehaviour {
	public GameObject girls;
	public GameObject kss;
	public GameObject Chem;
	private float delay;
	public GameObject pl;
	//public GameObject throwing;
	// Use this for initialization
	private int times;
	int index;
	public GameObject [] things;
	void Start () {
		delay = 1f;
		times = 1;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dis = new Vector3 (18.5f*times, 0, 0);
		if (delay <= 0) {
						Instantiate (girls,girls.transform.position+dis , Quaternion.identity);
						times++;
						delay=3f;					
						
				} else {
						delay -= Time.deltaTime;
				}	
	}
	void setindex( int i){
		index = i;
	}
	 void makeThing(Transform pos){
		Instantiate (things[index], pos.position, Quaternion.identity);
	}
	void createChem() {
		Instantiate (Chem,pl.transform.position+ Vector3.right*7+Vector3.up*2.1f,Quaternion.identity);
		ThrowingStuff.shoot = true;
	}
	void createKss(){
		Instantiate (kss, pl.transform.position + Vector3.right * 10 + Vector3.up * 3.1f, Quaternion.identity);
	}
}
