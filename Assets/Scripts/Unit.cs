using UnityEngine;
using System.Collections;

public class Unit {

	private Unit target;
	private Sprite unitSprite;
	private int HealthPoints;
	private GameObject GOUnit;
	private void Strike ();

	public const float unitSpeed;
	public Unit (GameObject newUnit)
	{
		GOUnit = newUnit;
		HealthPoints = 100;
	}

	public void addStuff(string item)
	{

	}

	public void Hit (int k)
	{
		target.HealthPoints -= k;
	}

	public void SetTarget (Unit newTarget)
	{
		target = newTarget;
	}

	public void Move(Vector2 vector)
	{
		GOUnit.transform.Translate (vector * Time.deltaTime * unitSpeed, Space.World);
	}


	
	void Start () {
	
	}
	

	void Update () {
		Strike ();
	}
}