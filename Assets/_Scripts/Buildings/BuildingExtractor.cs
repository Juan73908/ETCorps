using UnityEngine;
using System.Collections;

// Building that is placed on top of a resource
// Automatically extracts and sells it.
public class BuildingExtractor : Building {

	// Frecuency of resources extraction per upgrade level
	public float[] extractionTimers;

	// Resource that the building is extracting
	protected Resource resource;

	// Call coroutines
	void Start(){
		StartCoroutine(Extract());
	}

	// Initialization when instantiated
	public override void SetTile (Tile parentTile)
	{
		tile = parentTile;
		resource = tile.resource;
	}

	// Infinite coroutine for resource extraction and selling
	public IEnumerator Extract(){
		// Repeat forever
		while (1==1){
			// Wait depending on the upgrade level
			yield return new WaitForSeconds(extractionTimers[upgradeLevel]);
			// Sell the reosurce and increase player money balance. TODO
			GameObject.FindObjectOfType<Player>().addMoney(resource.Sell());
		}
	}
}
