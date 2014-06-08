using UnityEngine;
using System.Collections;


public abstract class Building : MonoBehaviour {

	public float price;
	public int upgradeLevel = 1;
	protected Tile tile;

	public abstract void Initialize(Tile tile);

}
