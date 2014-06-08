using UnityEngine;
using System.Collections;

// Controller for the resources in the game
public class ResourcesController : MonoBehaviour {

	// List of all resources
	public Resource[] resources;

	// Frecuency of update of prices
	public float updatePriceTime = 5.0f;
	
	public Resource GetRandomResource(){
		return resources[Random.Range(0, resources.Length)];
	}

	// Start coroutines
	void Start(){
		StartCoroutine(UpdatePrices());
	}

	// Infinite coroutine that update prices of every resource
	public IEnumerator UpdatePrices(){
		// Repeat forever
		while (1==1){
			yield return new WaitForSeconds(updatePriceTime);
			foreach(Resource resource in resources){
				resource.UpdatePrice();
			}
		}
	}
}
