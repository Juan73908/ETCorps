using UnityEngine;
using System.Collections;

// Label that displays the real time price of a resource + tendency
public class GUILabelResource : GUILabel {

	// The "tracked" resource
	public Resource resource;

	void Start(){
		// Change the color of the text to the color of the resource
		label.color = resource.MapIconColor;
	}

	// Called very frame
	protected override string UpdateLabel(){
		// Ignore the decimals with the (int) cast
		string updatedLabel = ((int)resource.sellPrice).ToString();
		// Depending of the tendency add + or -
		if (resource.GetSellPriceChange() > 0){
			updatedLabel += "+";
		} else {
			updatedLabel += "-";
		}
		return updatedLabel;
	}
}
