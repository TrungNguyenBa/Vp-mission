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
												if (direction.x > 5f) {
														delay=0.4f;
														Player.isStraight = false;
														Player.isLeft = false;
														Player.isRight = true;

												} else if (direction.x < -5f) {
														delay=0.4f;
														Player.isStraight = false;
														Player.isLeft = true;
														Player.isRight = false;
												}
												else {
														istap=true;
														Debug.Log("Tap");
														Player.isStraight = true;
														Player.isLeft = false;
														Player.isRight = false;
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
										delay = 0.4f;
										change=false;
										istap=false;
								} else {
										delay -= Time.deltaTime;
								
								}	

						}
				}
		}
}
