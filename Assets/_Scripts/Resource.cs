using UnityEngine;
using System.Collections;

public enum ResourceType{
	RED_MINERAL,
	YELLOW_MINERAL,
	GREEN_MINERAL,
	PURPLE_MINERAL,
	BLUE_MINERAL
}

public class Resource : MonoBehaviour {

	public ResourceType resourceType;

	public float sellPrice = 100;
	public float priceIncrementMin = 0.0f;
	public float priceIncrementMax = 0.1f;
	public float priceDecrement = 0.02f;

	public Sprite GUIIcon;
	public Sprite MapIcon;
	public Color MapIconColor;
	
	public void UpdatePrice(){
		sellPrice += sellPrice * Random.Range(priceIncrementMin, priceIncrementMax);
	}

	public float Sell(){
		float returnPrice = sellPrice;
		sellPrice -= sellPrice * priceDecrement;
		return returnPrice;
	}
}