using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour {

	[SerializeField]
	protected int value;

	[SerializeField]
	private Image valueBar;

	[SerializeField]
	private Text valueState;

	[SerializeField]
	protected int maxValue;

	// Use this for initialization
	protected virtual void Start () {
		if (value == 0) {
			value = maxValue;
		}
	}
	
	// Update is called once per frame
	protected void UpdateBar () {
		float ratio = (float) value / (float) maxValue;
		valueBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
		valueState.text = value + "/" + maxValue;
	}
}
