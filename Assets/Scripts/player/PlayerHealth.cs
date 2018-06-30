using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : PlayerState {

	

	// Use this for initialization
	protected override void Start () {
	
	}
	
	// Update is called once per frame
	protected override void Update () {
		base.Update();
		if (value > 0) {
			value--;
		}
	}

	public void makeDamage(int damage) {
		
	}
}
