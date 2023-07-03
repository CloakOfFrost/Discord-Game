using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Damage_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	//Kills player on collision with enemy and kills enemy on collision with the player's weapon
	public void OnCollisionEnter2D(Collision2D other)
        {
                if(other.gameObject.name != "Player"){
                        return;
                } else if (other.collider.tag != "Player Weapon") {
			Destroy(other.gameObject);
		} else {
			Destroy(this.gameObject);
		}
        }
}
