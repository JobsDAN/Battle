using UnityEngine;
using System.Collections;

public class Unit {

	private Unit target;
	private Sprite unitSprite;
	private int HealthPoints;
	private GameObject GOUnit;
	private float attackSpeed;
	private void Strike ()
	{
		int k = 50;
		if (target != null)
			target.Hit (k);
	}
	
	public const float movementSpeed;
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
		HealthPoints -= k;
	}

	public void SetTarget (Unit newTarget)
	{
		target = newTarget;
	}

	public void Move(Vector2 vector)
	{
		GOUnit.transform.Translate (vector * Time.deltaTime * movementSpeed, Space.World);
	}
	
	void Start () {
	
	}
	

	void Update () {
		Strike ();
	}
}