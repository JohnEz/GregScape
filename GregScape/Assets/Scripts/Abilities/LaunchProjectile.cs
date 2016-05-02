using UnityEngine;
using System.Collections;

public class LaunchProjectile : BaseAbility {

	public GameObject myProjectile;
	public Quaternion rotation;

	public GameObject MyProjectile {
		get { return myProjectile; }
		set { myProjectile = value;}
	}

	public Quaternion Rotation {
		get { return rotation; }
		set { rotation = value;}
	}


	public override bool UseAbility (Vector3 position, Vector2 direction)
	{
		//if it passes its base checks
		if (base.UseAbility (position, direction)) {
			float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg;
			rotation = Quaternion.AngleAxis (angle, Vector3.forward);

			//create the projectile
			Effect (position);

			return true;
		}

		return false;
	}

	void Effect(Vector3 position) {
		Instantiate (myProjectile, position, rotation);
	}

}
