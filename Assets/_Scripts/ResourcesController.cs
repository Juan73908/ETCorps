using UnityEngine;
using System.Collections;

public class ResourcesController : MonoBehaviour {

	public Resource[] resources;
	
	public float updatePriceTime = 5.0f;

	public Resource GetRandomResource(){
		return resources[Random.Range(0, resources.Length)];
	}

	void Start(){
		StartCoroutine(UpdatePrices());
	}

	public IEnumerator UpdatePrices(){
		while (1==1){
			yield return new WaitForSeconds(updatePriceTime);
			foreach(Resource resource in resources){
				resource.UpdatePrice();
			}
		}
	}
}
