using UnityEngine;
using System.Collections;

public class PlayerControlle : MonoBehaviour {
	Vector2 startpos;
	Vector2 direction;
	float delay;
	bool change;
	bool istap;

	// Use this for initialization
	void Start () {
		delay = 1f;
		change = false;
		istap = false;
	}
	
	// Update is called once per frame
	void Update () {
				{
						if (Input.touchCount > 0) {
								Touch t = Input.GetTouch (0);
								
								switch (t.phase) {
								case TouchPhase.Began:
										{	
												startpos = t.position;
												break;
										}
							
								case TouchPhase.Ended:
								{							
												direction = t.position - startpos;
												change = true;
												;
												if (direction.x > 7f) {
														delay=0.57f;
														Player.isStraight = false;
														Player.isLeft = false;
														Player.isRight = true;
														Player.isBlocking = false;

												} else if (direction.x < -7f){
														delay=0.57f;
														Player.isStraight = false;
														Player.isLeft = true;
														Player.isRight = false;
														Player.isBlocking = false;
												}
												else {
														istap=true;
														//Debug.Log("Tap");
														delay=0.57f;
														Player.isBlocking = true;
														Player.isLeft = false;
														Player.isRight = false;
														Player.isStraight=false;
																				}
												//Debug.Log (direction.x.ToString());
												break;
												
										}
								}
									
				}
					if (change) {
								if (delay < 0) {
										Player.isStraight = true;
										Player.isLeft = false;
										Player.isRight = false;
										Player.isBlocking = false;
										delay = 0.57f;
										change=false;
										istap=false;
								} else {
										delay -= Time.deltaTime;
								
								}	

						}
				}
		}
}
