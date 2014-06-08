using UnityEngine;
using System.Collections;

// Generic squared piece of map
public class Tile : MonoBehaviour {

	// If the tile should have a random resource on it
	public bool hasResource = false;
	// The actual resource on the tile (if any)
	[HideInInspector]
	public Resource resource = null;

	// if there is a building on the tile
	[HideInInspector]
	public bool hasBuilding = false;
	// Prefab of the only building that can be placed in this tile. TODO
	public Building buildingPrefab;
	// The actual building on the tile (if any)
	[HideInInspector]
	public Building building = null;

	// Where the diferent sprites should be placed
	public SpriteRenderer tileModel;
	public SpriteRenderer resourceModel;
	
	// Initialization
	public void SetResource(Resource newResource){
		resource = newResource;
		// Show
		resourceModel.sprite = resource.MapIcon;
		resourceModel.color = resource.MapIconColor;
	}

	// Simple building and destoying mechanis. TODO
	void OnMouseDown(){
		// If there is no building and player has money
		if ((buildingPrefab != null) && (building == null) && (GameObject.FindObjectOfType<Player>().money >= buildingPrefab.price)){
			building = (Building)Instantiate(buildingPrefab);
			building.SetTile(this);
			building.transform.parent = transform;
			building.transform.position = transform.position;
			// Player pays the price of the building
			GameObject.FindObjectOfType<Player>().addMoney(-building.price);
		} else
			// If there is a building destroy it
		if ((buildingPrefab != null) && (building != null)){
			Destroy(building.gameObject);
		}
	}
}
