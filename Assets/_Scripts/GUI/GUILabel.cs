using UnityEngine;
using System.Collections;

// Parent class for the GUI labels in the game
public abstract class GUILabel : MonoBehaviour {

	// Label that shows the text on the screen
	protected GUIText label;
	// Allow to dinamically change the size of the font independently of the screen resolution
	public int dinamicFontSize = 26;

	// Initialization
	void Awake () {
		// Get reference from the gameObject
		label = GetComponent<GUIText>();
		// Unity trick to create dinamic fonts
		label.fontSize = (int)(Screen.height * dinamicFontSize * 0.0035f);
	}
	
	// Update screen
	void Update () {
		// Update label every frame. Not very efficient but fast to implement.
		label.text = UpdateLabel();
	}
	
	// Leave the update mechanism to the child clases
	protected abstract string UpdateLabel();
}
