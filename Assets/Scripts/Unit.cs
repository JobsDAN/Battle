using UnityEngine;
using System.Collections;

public class Unit {

	private Unit target;
	private Sprite unitSprite;
	private int HealthPoints;
	private GameObject GOUnit;
	private void Strike () {;}

	public void addStuff(string item) {;}
	public void Hit (int k) {;}

	public const float unitSpeed = 1.0f;

	public void Update () {
		Strike ();
	}

	public Unit (GameObject newUnit)
	{
		GOUnit = newUnit;
	}

	public void Move(Vector2 vector)
	{
		GOUnit.transform.Translate (vector * Time.deltaTime * unitSpeed, Space.World);
	}

	public void SetTarget (Unit newTarget)
	{
		target = newTarget;
	}
}