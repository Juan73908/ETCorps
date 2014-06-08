using UnityEngine;
using System.Collections;

public class GUILabelResource : GUILabel {

	public Resource resource;
	public SpriteRenderer resourceIcon;

	void Start(){
		text.color = resource.MapIconColor;
		resourceIcon.sprite = resource.GUIIcon;
	}

	protected override string UpdateLabel(){
		string updatedLabel = ((int)resource.sellPrice).ToString();
		if (resource.GetSellPriceChange() > 0){
			updatedLabel += "+";
		} else {
			updatedLabel += "-";
		}
		return updatedLabel;
	}
}
