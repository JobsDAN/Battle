using UnityEngine;
using System.Collections;

public class Unit {

	private Unit target;
	private Sprite unitSprite;
	private int HealthPoints;
	private GameObject GOUnit;
	private void Strike ();

	public Unit(GameObject newUnit);
	public void Init();
	public void addStuff(string item);
	public void Hit (int k);
	public void SetTarget (Unit newTarget);
	public void Move (Vector2 vector);

	public const float unitSpeed;
	
	void Start () {
	
	}
	

	void Update () {
		Strike ();
	}

	Unit (GameObject newUnit)
	{
		GOUnit = newUnit;
	}

	void Move(Vector2 vector)
	{
		GOUnit.transform.Translate (vector * Time.deltaTime * unitSpeed, Space.World);
	}

	void SetTarget (Unit newTarget)
	{
		target = newTarget;
	}
}