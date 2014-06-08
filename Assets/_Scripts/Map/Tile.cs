using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public bool hasResource = false;
	[HideInInspector]
	public Resource resource = null;
	public Building buildingPrefab;
	[HideInInspector]
	public Building building = null;
	[HideInInspector]
	public bool hasBuilding = false;
	
	public SpriteRenderer tileModel;
	public SpriteRenderer resourceModel;

	public void SetResource(Resource newResource){
		resource = newResource;
		// Show
		resourceModel.sprite = resource.MapIcon;
		resourceModel.color = resource.MapIconColor;
	}

	// Temporal
	void OnMouseDown(){
		if ((buildingPrefab != null) && (building == null) && (GameObject.FindObjectOfType<Player>().money >= buildingPrefab.price)){
			building = (Building)Instantiate(buildingPrefab);
			building.Initialize(this);
			building.transform.parent = transform;
			building.transform.position = transform.position;
			GameObject.FindObjectOfType<Player>().addMoney(-building.price);
		} else
		if ((buildingPrefab != null) && (building != null)){
			Destroy(building.gameObject);
		}
	}
}
