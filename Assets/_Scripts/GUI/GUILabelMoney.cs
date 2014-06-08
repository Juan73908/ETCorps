using UnityEngine;
using System.Collections;

public class GUILabelMoney : GUILabel {

	protected override string UpdateLabel(){
		return FormatMoney((int)GameObject.FindObjectOfType<Player>().money);
	}

	protected string FormatMoney(int value){
		return string.Format("{0:C}", value.ToString());
	}
}
