﻿using UnityEngine;
using System.Collections;

public class Slideleft : MonoBehaviour  {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (Player.isLeft) {
			this.renderer.enabled=true;	
			this.collider2D.enabled=true;
		} else {
			this.renderer.enabled=false;
			this.collider2D.enabled=false;
		}
	}
}
