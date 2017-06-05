using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GameTile : MonoBehaviour {
	public bool hasNorth;
	public bool hasEast;
	public bool hasSouth;
	public bool hasWest;

	private GameObject tileSetupObject;
	private TileSetup tileSetup;

	private Vector3 tilePosition;
	private Vector3 tileSize;

	// TODOS:
	// Variable entrance positions
	// Variable size(related to above?)
	// Nice to have: 
	// No two of the same tile in a row

	void Start () {
		tileSetupObject = GameObject.Find("TileSetup");
		tileSetup = tileSetupObject.GetComponent<TileSetup>();

		tilePosition = transform.position;
		tileSize = transform.Find("Floor").GetComponent<Renderer>().bounds.size;


	}
	void OnTriggerEnter(Collider col) {
        if (col.name == "Player") {
        		
        		InstantiateTiles();
        	}   
        }


	void Update () {
		
	}

	void InstantiateTiles() {
		DestroyTiles();

		gameObject.name = "currentTile";

		if (hasNorth) {
			int northRand = Random.Range(0,tileSetup.tileWithSouth.Count);
			GameObject northTile = Instantiate(tileSetup.tileWithSouth[northRand]);
			northTile.name = "northTile";
			northTile.transform.position = new Vector3(tilePosition.x - tileSize.x, 0, tilePosition.z);
		}
		if (hasSouth) {
			int southRand = Random.Range(0,tileSetup.tileWithNorth.Count);
			GameObject southTile = Instantiate(tileSetup.tileWithNorth[southRand]);
			southTile.name = "southTile";
			southTile.transform.position = new Vector3(tilePosition.x + tileSize.x, 0, tilePosition.z);
		}
		if (hasEast) {
			int eastRand = Random.Range(0,tileSetup.tileWithWest.Count);
			GameObject eastTile = Instantiate(tileSetup.tileWithWest[eastRand]);
			eastTile.name = "eastTile";
			eastTile.transform.position = new Vector3(tilePosition.x, 0, tilePosition.z + tileSize.z);
		}
		if (hasWest) {
			int westRand = Random.Range(0,tileSetup.tileWithEast.Count);
			GameObject westTile = Instantiate(tileSetup.tileWithEast[westRand]);
			westTile.name = "westTile";
			westTile.transform.position = new Vector3(tilePosition.x, 0, tilePosition.z - tileSize.z);
		}

	}

	 void DestroyTiles() {
	 	GameObject[] tiles;
     	tiles = GameObject.FindGameObjectsWithTag("Tile");
     	foreach (GameObject tile in tiles)
	     {
	     	// Loop for each tile
	     	if (tile != gameObject) {
	     		Destroy(tile);
	     	}
	     	
	     }
	 }
}
