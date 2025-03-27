using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerController : MonoBehaviour
{
    public Animator animator;
    Rigidbody2D rb;
    [SerializeField] float vertical, horizontal, life, maxLife;
    [SerializeField] float speed;
    [SerializeField] bool facinRight;
    [SerializeField] SpriteRenderer spriteRenderer;
    public float Speed { get => speed; }

    private float horizontalInput, verticalInput;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        maxLife = life;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Walk", Mathf.Abs(horizontalInput));
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal, vertical) * Speed;
    }
}
