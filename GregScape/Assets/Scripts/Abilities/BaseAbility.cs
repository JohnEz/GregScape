using UnityEngine;
using System.Collections;

public class BaseAbility : MonoBehaviour  {

	float maxCooldown;
	float cooldown;
	int cost;

	BaseCharacter caster;

	public float Cooldown {
		get { return cooldown; }
		set { cooldown = value;}
	}

	public float MaxCooldown {
		get { return maxCooldown; }
		set { maxCooldown = value;}
	}

	public int Cost {
		get { return cost; }
		set { cost = value;}
	}

	public BaseCharacter Caster {
		get { return caster; }
		set { caster = value;}
	}

	public void Update() {
		if (cooldown > 0) {
			cooldown -= Time.deltaTime;
		}
	}

	public void SetOnCooldown(bool onCD) {
		if (onCD) {
			cooldown = maxCooldown;
		} else {
			cooldown = 0;
		}
	}

	public virtual bool UseAbility(Vector3 position, Vector2 direction) {
		// if its not on cooldown
		if (cooldown <= 0) {
			//if it has a caster
			if (caster) {
				//if caster has enough resource
				if (caster.Resource >= cost) {
					caster.Resource -= cost;
					SetOnCooldown (true);
					return true;
				}
			}
		}
		return false;
	}

}
