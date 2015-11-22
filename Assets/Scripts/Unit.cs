using UnityEngine;
using System.Collections;

public class Unit {

	private Unit target;
	private Sprite unitSprite;
	private int healthPoints;
	private GameObject GOUnit;
	private float attackSpeed;
	private void Strike ()
	{
		int k = 50;
		if (target != null)
			target.Hit (k);
	}

	private void Die ()
	{
		this.GOUnit = null;
	}
	
	public const float movementSpeed = 2.0f;
	public Unit (GameObject newUnit)
	{
		GOUnit = newUnit;
		healthPoints = 100;
	}

	public void addStuff(string item)
	{

	}

	public void Hit (int k)
	{
		healthPoints -= k;
		if (healthPoints <= 0)
			Die();
	}

	public void SetTarget (Unit newTarget)
	{
		target = newTarget;
	}

	public void Move(Vector2 vector)
	{
		GOUnit.transform.Translate (vector * Time.deltaTime * movementSpeed, Space.World);
	}
	
	public void Update () {
		Strike ();
	}
}
