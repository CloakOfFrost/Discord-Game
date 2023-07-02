using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player_Move_Script : MonoBehaviour
{
    public float Speed;
    public float Rotation_speed;
    private float Move;

    [SerializeField] private GameObject sword;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       Move = Input.GetAxis("Horizontal");
       rb.velocity = new Vector2(Move * Speed, rb.velocity.y);

        sword.transform.position=transform.position+transform.up/2;
        sword.transform.rotation=transform.rotation;

       { Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
 float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg - 90    ;
 Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, gameObject.GetComponent<Player_Move_Script>().    Rotation_speed * Time.deltaTime);
    }
    }
}
