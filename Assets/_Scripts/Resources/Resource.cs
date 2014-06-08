using UnityEngine;
using System.Collections;

// Global enum for all the types of resources in the game
public enum ResourceType{
	RED_MINERAL,
	YELLOW_MINERAL,
	GREEN_MINERAL,
	PURPLE_MINERAL,
	BLUE_MINERAL
}

// Takes care of controlling the prices changes and selling of a particular resource
public class Resource : MonoBehaviour {

	// Defined in the inspector
	public ResourceType resourceType;

	// The amount of money you get selling the resource
	public float sellPrice = 100;
	protected float previousSellPrice;
	// Min and max random increase values of the price
	public float priceIncrementMin = 0.0f;
	public float priceIncrementMax = 0.1f;
	// Amount of decrement of the price when selling
	public float priceDecrement = 0.02f;

	// Representation values asigned in the inspector
	public Sprite MapIcon;
	public Color MapIconColor;

	// Initialization
	void Awake(){
		previousSellPrice = sellPrice;
	}

	// Called by the resource manager 
	public void UpdatePrice(){
		sellPrice += sellPrice * Random.Range(priceIncrementMin, priceIncrementMax);
	}

	public float Sell(){
		previousSellPrice = sellPrice;
		sellPrice -= sellPrice * priceDecrement;
		return previousSellPrice;
	}

	public float GetSellPriceChange(){
		return (sellPrice - previousSellPrice);
	}
}