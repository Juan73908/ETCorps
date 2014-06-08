using UnityEngine;
using System.Collections;

public abstract class GUILabel : MonoBehaviour {

	protected GUIText text;
	public int dinamicFontSize = 26;

	protected string labelText;

	// Use this for initialization
	void Awake () {
		text = GetComponent<GUIText>();
		text.fontSize = (int)(Screen.height * dinamicFontSize * 0.0035f);
	}
	
	// Update is called once per frame
	void Update () {
		UpdateLabel();
		text.text = UpdateLabel();
	}

	protected abstract string UpdateLabel();
}
