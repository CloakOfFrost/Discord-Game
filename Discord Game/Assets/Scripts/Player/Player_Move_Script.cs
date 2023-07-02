using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player_Move_Script : MonoBehaviour
{
	private float horizontalInput;
	//serialize feild allows you to change a variable in from editor without making it public | public variables can be influenced by other scripts
	[SerializeField] private float movementSpeed;
        [SerializeField] private float rotationSpeed;
        [SerializeField] private GameObject sword;
	private Rigidbody2D rigidBody;
	
        // Start is called before the first frame update
        void Start()
        {
        	rigidBody = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
		/*
		This code is for movement
		horizontalInput can return any value from -1 to 1
		Time.deltaTime is the time since last frame (so framerate wont influence speed because speed is multiplied by Time.DeltaTime)
		*/
		horizontalInput = Input.GetAxis("Horizontal");
		rigidBody.velocity = new Vector2(horizontalInput * movementSpeed * Time.deltaTime, rigidBody.velocity.y);
		
		turn_to_mouse(rotationSpeed);
        }
	
	void turn_to_mouse(float speed) {
		//This code slowly rotates the player towards the mouse based on speed
        	Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        	float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg - 90;
        	Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        	transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, speed * Time.deltaTime);
	}
}
