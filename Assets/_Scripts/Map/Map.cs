using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Create and controlls all tiles in the map
public class Map : MonoBehaviour {

	// Different tiles in the game
	// Adding the same tile more than once increases the chances of it appearing
	public Tile[] tilePrefabs;
	// Reference to the controller of resources to be asigned in the inspector
	public ResourcesController resourcesController;

	// How big the map should be
	public Vector2 mapSize = new Vector2(16, 10);

	// Safe references
	void Awake(){
		if (resourcesController == null)
			resourcesController = GameObject.FindObjectOfType<ResourcesController>();
	}
	
	void Start(){
		GenerateRandomMap();
	}

	// Creates a random symetrical map
	void GenerateRandomMap(){
		Vector3 tilePos = transform.position - (Vector3)mapSize/(2.0f);
		for (int i = 0; i < mapSize.x/2; i++){
			for (int j = 0; j < mapSize.y; j++){
				int randomIndex = Random.Range(0, tilePrefabs.Length);
				// Create a new tile
				Tile newTile = (Tile)Instantiate(tilePrefabs[randomIndex]);
				newTile.transform.position = tilePos + new Vector3(i+0.5f, j+0.5f, 0);
				newTile.transform.parent = transform;
				if (newTile.hasResource){
					// Set a random resource for the tiles that should have
					newTile.SetResource(resourcesController.resources[Random.Range(0, resourcesController.resources.Length)]);
				}
				// Mirror the tile in the other side of the map
				newTile = (Tile)Instantiate(newTile);
				newTile.transform.position = tilePos + new Vector3(mapSize.x-i-0.5f, j+0.5f, 0);
				newTile.transform.parent = transform;
			}
		}
	}
}
