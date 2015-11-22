using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;

public class Game : MonoBehaviour {

	public Allies currentUnit;
	public LinkedList<Unit> units;
	public Sprite enemySprite, playerSprite;

	// Use this for initialization
	void Start () {
		Unit player = createUnit (playerSprite, new Vector2(1, 0));
		Unit enemy = createUnit (enemySprite,  new Vector2(-1, 0));
		units.AddLast (player);
		units.AddLast (enemy);
	}

	Unit createUnit(Sprite sprite, Vector2 position) {
		GameObject go = new GameObject ();
		go.transform.position = (Vector3)position;
		SpriteRenderer sr = go.AddComponent<SpriteRenderer> ();
		sr.sprite = sprite;
		Unit unit = new Unit (go);
		return unit;
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Unit unit in units) {
			unit.Update();
		}
	}
}
