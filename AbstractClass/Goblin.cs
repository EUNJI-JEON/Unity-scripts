using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : BaseMonster {
	
	public override void Attack()
	{
		Debug.Log("Attack! damage power: "+damage);
	}
	
}
