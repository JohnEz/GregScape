using UnityEngine;
using System.Collections;

public class MusketShot : LaunchProjectile {

	public GameObject shotEffect; 

	public MusketShot() : base () {
		MaxCooldown = 1.5f;
	}

	public void Start() {
		Caster = GetComponent<BaseCharacter> ();
	}

	public override bool UseAbility (Vector3 position, Vector2 direction)
	{
		if (base.UseAbility (position, direction)) {
			if (shotEffect) {
				GameObject.Instantiate (shotEffect, position, Rotation);
			}
			return true;
		}
		return false;
	}

}
