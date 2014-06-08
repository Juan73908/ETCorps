using UnityEngine;
using System.Collections;

// Label that displays the real time money of a player
public class GUILabelMoney : GUILabel {

	// Called every frame
	protected override string UpdateLabel(){
		// Ignore the decimals with the (int) cast. TODO
		return FormatMoney((int)GameObject.FindObjectOfType<Player>().money);
	}

	protected string FormatMoney(int value){
		// "ToString("C0")" returns the string in "currency" format without decimals
		// We remove the first caracter because it is a "$" symbol
		return value.ToString("C0").Remove(0,1);
	}
}
