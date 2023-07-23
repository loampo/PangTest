using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerController : MonoBehaviour
{
    public float speed;
    public float fireRate;
    private Rigidbody2D _rb;
    private PlayerShooting _shooting;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _shooting = GetComponent<PlayerShooting>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameManager.instance.UIManager.Pause();
        }

        _rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, _rb.velocity.y);

        //if (Input.GetKeyDown(KeyCode.Space))
        //{

        //}
    }
}
