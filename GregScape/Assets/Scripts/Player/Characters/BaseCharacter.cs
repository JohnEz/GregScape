using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseCharacter : MonoBehaviour {

	private string name;
	private string description;
	private Dictionary<string, BaseAbility> abilities = new Dictionary<string, BaseAbility>();

	//stats
	private int strength = 5;
	private int intellect = 5;
	private int agility = 5;
	private int movespeed = 0;
	private int resource = 5;

	public string Name {
		get { return name; }
		set { name = value;}
	}

	public string Description {
		get { return description; }
		set { description = value;}
	}

	public int Strength {
		get { return strength; }
		set { strength = value;}
	}

	public int Intellect {
		get { return intellect; }
		set { intellect = value;}
	}

	public int Agility {
		get { return agility; }
		set { agility = value;}
	}

	public int Movespeed {
		get { return movespeed; }
		set { movespeed = value;}
	}

	public int Resource {
		get { return resource; }
		set { resource = value;}
	}

	public Dictionary<string, BaseAbility> Abilities {
		get { return abilities; }
		set { abilities = value;}
	}

	void Start() {

	}

	void Update() {

	}

	public virtual bool Attack1(Vector3 position, Vector2 direction) {
		return false;
	}

	public virtual bool Attack2(Vector3 position, Vector2 direction) {
		return false;
	}

}
