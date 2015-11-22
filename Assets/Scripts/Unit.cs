using UnityEngine;
using System.Collections;

public class Unit : GameObject {

	private Unit target;
	private Sprite unitSprite;
	private int HealthPoints;
	private void Strike ();

	public Unit();
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

	void Move(Vector2 vector)
	{
		transform.Translate (vector * Time.deltaTime * unitSpeed, Space.World);
	}

	void SetTarget (Unit newTarget)
	{
		target = newTarget;
	}
}
