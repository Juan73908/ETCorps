using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Map : MonoBehaviour {

	public Tile[] tilePrefabs;
	public ResourcesController resourcesController;

	public Vector2 mapSize = new Vector2(30, 15);

	void Awake(){
		if (resourcesController == null)
			resourcesController = GameObject.FindObjectOfType<ResourcesController>();
	}

	void Start(){
		GenerateRandomMap();
	}


	void GenerateRandomMap(){
		Vector3 tilePos = transform.position - (Vector3)mapSize/(2.0f);
		for (int i = 0; i < mapSize.x/2; i++){
			for (int j = 0; j < mapSize.y; j++){
				int randomIndex = Random.Range(0, tilePrefabs.Length);
				Tile newTile = (Tile)Instantiate(tilePrefabs[randomIndex]);
				newTile.transform.position = tilePos + new Vector3(i+0.5f, j+0.5f, 0);
				newTile.transform.parent = transform;
				if (newTile.hasResource){
					newTile.SetResource(resourcesController.resources[Random.Range(0, resourcesController.resources.Length)]);
				}
				newTile = (Tile)Instantiate(newTile);
				newTile.transform.position = tilePos + new Vector3(mapSize.x-i-0.5f, j+0.5f, 0);
				newTile.transform.parent = transform;
			}
		}
	}
}
