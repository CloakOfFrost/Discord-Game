using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
public class Enemy_Movement_Script : MonoBehaviour
{
	[SerializeField] private GameObject player;
	public float Speed;
	// Start is called before the first frame update
	void Start()
	{
        	
	}
	
	// Update is called once per frame
	void Update()
	{
		//Moves the enemy twards the player but cannot jump
        	if(player.transform.position.x > transform.position.x){
        		transform.position+=new Vector3(Speed,0,0);
        	}
        	if(player.transform.position.x < transform.position.x){
        		transform.position-=new Vector3(Speed,0,0);
        	}
    	}
}
