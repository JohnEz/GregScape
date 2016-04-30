using UnityEngine;
using System.Collections;

public class BaseCharacter : MonoBehaviour {

	private string name;
	private string description;

	//stats
	private int strength = 5;
	private int intellect = 5;
	private int agility = 5;
	private int movespeed = 0;

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

	void Start() {

	}

	void Update() {

	}

}
