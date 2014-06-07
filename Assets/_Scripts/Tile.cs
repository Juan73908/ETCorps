using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public bool hasResource = false;
	protected Resource resource = null;
	
	public SpriteRenderer tileModel;
	public SpriteRenderer resourceModel;

	void Start(){
		if (hasResource){
			Resource[] allResources = GameObject.FindObjectsOfType<Resource>();
			resource = allResources[Random.Range(0, allResources.Length)];
			// Show
			resourceModel.sprite = resource.MapIcon;
			resourceModel.color = resource.MapIconColor;
		}
	}

}
