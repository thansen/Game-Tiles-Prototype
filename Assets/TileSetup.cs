using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSetup : MonoBehaviour {

	private GameObject[] tilePrefabsArray;

	public List<GameObject> tileWithNorth;
	public List<GameObject> tileWithSouth;
	public List<GameObject> tileWithEast;
	public List<GameObject> tileWithWest;

	// Use this for initialization
	void Start () {
		tilePrefabsArray = Resources.LoadAll<GameObject>("tilePrefabs");


		foreach (GameObject tile in tilePrefabsArray) {
			if (tile.GetComponent<GameTile>().hasNorth) {
				tileWithNorth.Add(tile);
			}
			if (tile.GetComponent<GameTile>().hasSouth) {
				tileWithSouth.Add(tile);
			}
			if (tile.GetComponent<GameTile>().hasEast) {
				tileWithEast.Add(tile);
			}
			if (tile.GetComponent<GameTile>().hasWest) {
				tileWithWest.Add(tile);
			}
			
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
