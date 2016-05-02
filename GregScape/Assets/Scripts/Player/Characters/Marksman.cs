using UnityEngine;
using System.Collections;

public class Marksman : BaseCharacter {

	public Marksman() {
		Name = "Marksman";
		Description = "Fast ranged character that uses guns or some shiz";
		Strength = 3;
		Intellect = 4;
		Agility = 8;
		Movespeed = 15;
	}

	void Start() {
		Abilities.Add("Ability1", GetComponent<MusketShot>());
	}

	public override bool Attack1 (Vector3 position, Vector2 direction)
	{
		return Abilities ["Ability1"].UseAbility (position, direction);
	}

}
