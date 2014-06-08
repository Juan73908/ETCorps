using UnityEngine;
using System.Collections;

// Takes care of player global variables
public class Player : MonoBehaviour {

	// The number of the player. TODO
	public int number = 1;

	// The account money balance
	public float money = 300.0f;

	// Add money to the account. Negative values decrease the balance.
	public void addMoney(float value){
		money += value;
	}

}
