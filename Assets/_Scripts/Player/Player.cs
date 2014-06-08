using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int number = 1;

	public float money = 300.0f;

	public void addMoney(float value){
		money += value;
	}

}
