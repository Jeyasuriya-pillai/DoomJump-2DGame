using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // 1. REQUIRED: Gives us access to the Image component

public class Player : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    public int maxJumps = 2;       

    [Header("Health & UI")]
    public float health = 100f; 
    public Image healthImage; // 2. Drag your UI Heart/Bar Fill image here in the Inspector

    private Rigidbody2D rb;
    private Animator animator; 
    private SpriteRenderer spriteRenderer; 
    private bool isGrounded;
    private int jumpsRemaining;    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>(); 
        jumpsRemaining = maxJumps; 
        
        UpdateHealthUI(); // Initialize UI fill amount at start
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        if (isGrounded) jumpsRemaining = maxJumps; 

        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || jumpsRemaining > 1))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            jumpsRemaining--; 
        }

        SetAnimation(moveInput);
    }

    void FixedUpdate()
    {   
        if (groundCheck) isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    }

    void SetAnimation(float moveInput)
    {
        if (isGrounded)
        {
            animator.Play(moveInput == 0 ? "PlayerAni" : "PlayerRunAni");
        }
        else
        {
            if (rb.linearVelocity.y > 0.1f) animator.Play("PlayerJumpAni");
            else if (rb.linearVelocity.y < -0.1f) animator.Play("PlayerFallAni");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Damage"))
        {
            health -= 25f;
            UpdateHealthUI(); // 3. Update the UI fill whenever you take damage
            
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            StartCoroutine(BlinkRed());
            if (health <= 0) SceneManager.LoadScene("SampleScene");
        }
    }

    // Extracted method from your image to keep the code organized
    void UpdateHealthUI()
    {
        if (healthImage != null)
        {
            // Divides current health by max health (100) to get a value between 0.0f and 1.0f
            healthImage.fillAmount = health / 100f; 
        }
    }

    private IEnumerator BlinkRed()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        spriteRenderer.color = Color.white;
    }
}