using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float vertical, horizontal, life, maxLife;
    [SerializeField] float speed;
    [SerializeField] bool facinRight;
    public float Speed { get => speed; }

    // Start is called before the first frame update
    void Start()
    {
        maxLife = life;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal, vertical) * Speed;
    }
}
