using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMana : PlayerState {
	
	protected override void Start () {
		
	}

    // Update is called once per frame
    protected override void Update () {
		base.Update();
		if (value > 0) {
			value--;
		}
	}
}
