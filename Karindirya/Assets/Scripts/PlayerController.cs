using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed = 5f;
    private Vector2 moveInput;
    public bool IsMoving { get; private set; }
    
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private bool canPickup = false;
    private GameObject nearbyItem;
    private GameObject itemToPickup;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Simple input handling using horizontal and vertical axes
        float horizontalInput = Input.GetAxisRaw("Horizontal");  // A/D or Left/Right arrows
        float verticalInput = Input.GetAxisRaw("Vertical");      // W/S or Up/Down arrows
        
        // Create movement vector
        moveInput = new Vector2(horizontalInput, verticalInput);
        IsMoving = moveInput != Vector2.zero;

        // Handle pickup input - only when E is pressed AND we're near an item
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canPickup && nearbyItem != null)
            {
                PickupItem();
                // Start the delay for destruction
                Invoke("FinishPickup", 3.0f);
            }
        }

        // Handle animations
        UpdateAnimations();
    }

    void FixedUpdate()
    {
        // Move the player
        Vector2 movement = moveInput.normalized;
        rb.linearVelocity = movement * walkSpeed;
    }

    void UpdateAnimations()
    {
        // Update walking animation
        animator.SetBool("IsWalking", IsMoving);

        // Update sprite direction
        if (moveInput.x != 0)
        {
            spriteRenderer.flipX = moveInput.x < 0;
        }
    }

    void PickupItem()
    {
        animator.SetTrigger("Pickup");
        itemToPickup = nearbyItem;
        
        // Get the ingredient name from the object (you should name your ingredient objects appropriately)
        string ingredientName = itemToPickup.name.Replace("(Clone)", "").Trim();
        
        // Notify GameManager about the collected ingredient
        if (GameManager.Instance != null)
        {
            GameManager.Instance.CollectIngredient(ingredientName);
        }
        
        canPickup = false;
        nearbyItem = null;
        Debug.Log("Starting pickup animation for: " + ingredientName);
    }

    void FinishPickup()
    {
        if (itemToPickup != null)
        {
            string ingredientName = itemToPickup.name.Replace("(Clone)", "").Trim();
            Debug.Log("Finishing pickup of: " + ingredientName);
            Destroy(itemToPickup);
            itemToPickup = null;
        }
    }

    // Detect when player enters pickup range
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pickupable"))
        {
            string ingredientName = other.gameObject.name.Replace("(Clone)", "").Trim();
            
            // Only allow pickup if the ingredient hasn't been collected yet
            if (GameManager.Instance == null || !GameManager.Instance.IsIngredientCollected(ingredientName))
            {
                canPickup = true;
                nearbyItem = other.gameObject;
                Debug.Log("Near item: " + ingredientName + ". Press E to pick up.");
            }
        }
    }

    // Detect when player leaves pickup range
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Pickupable"))
        {
            canPickup = false;
            nearbyItem = null;
        }
    }
}
