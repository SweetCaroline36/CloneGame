using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController2D controller;

    //[SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private CapsuleCollider2D capsuleCollider;
    [SerializeField] private Animator animatorController;
    //[SerializeField] private BoxCollider2D boxCollider;
    //[SerializeField] private PhysicsMaterial2D notSlippery;
    //[SerializeField] private Sprite deadImage;
    [SerializeField] private float runSpeed = 40f;
    private float horizontalMove = 0f;
    private bool jump = false;

    void Start()
    {
        
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    public void killClone()
    {
        gameObject.layer = 0;
        animatorController.enabled = false;
        //spriteRenderer.sprite = deadImage;
        //capsuleCollider.sharedMaterial = notSlippery;
        //boxCollider.enabled = true;
        //capsuleCollider.enabled = false;
        Destroy(this);
    }
}
