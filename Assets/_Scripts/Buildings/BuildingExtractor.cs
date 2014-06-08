using UnityEngine;
using System.Collections;

public class BuildingExtractor : Building {

	public float[] extractionTimers;
	protected Resource resource;

	void Start(){
		StartCoroutine(Extract());
	}

	public override void Initialize (Tile parentTile)
	{
		tile = parentTile;
		resource = tile.resource;
	}


	public IEnumerator Extract(){
		while (1==1){
			yield return new WaitForSeconds(extractionTimers[upgradeLevel]);
			// Temporal
			GameObject.FindObjectOfType<Player>().addMoney(resource.Sell());
		}
	}
}
