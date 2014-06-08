using UnityEngine;
using System.Collections;

// Interface for all the types of buildings
public abstract class Building : MonoBehaviour {

	// Cost in Zoltoids
	public float price;

	// Level of upgrade (1 or 2)
	public int upgradeLevel = 1;

	// Tile where the building is placed
	protected Tile tile;

	// Should be called when the building is instantiated
	public abstract void SetTile(Tile tile);

}
