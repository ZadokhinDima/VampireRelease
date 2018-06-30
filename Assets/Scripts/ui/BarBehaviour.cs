using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarBehaviour : MonoBehaviour {

	public static void updateBar(Image Bar, Text state, int value, int maxValue) {
		float ratio = (float) value / (float) maxValue;
		Bar.rectTransform.localScale = new Vector3(ratio, 1, 1);
		state.text = value + "/" + maxValue;
	}

}
