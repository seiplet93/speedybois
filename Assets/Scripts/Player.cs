using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private Transform groundCheckTransform = null;
    [SerializeField] private LayerMask playerMask;

    private bool jumpKeyWayPressed;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;
    private int superJumpsRemaining;
    private int runSpeed = 5;

    
    // Animator _animator;
    // private void Awake() => _animator = GetComponent<Animator>();
    

    // private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame (based on the rednering speed of users pc) (do checks in here, keydown etc, but no physics)
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWayPressed = true;
            
        }

        horizontalInput = Input.GetAxis("Horizontal");
      
    }
    

    // FixedUpdate is called once every physic update (Unity sets this to 100hz by default, or 100fps) (put all physics on here, this is a controlled way to make physics consistent.)
    private void FixedUpdate()
    {
        // if (!isGrounded){return;}
        rigidbodyComponent.velocity = new Vector3(horizontalInput * runSpeed, rigidbodyComponent.velocity.y, 0);
        
        

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0)
        {
            return;
        }

        if (jumpKeyWayPressed == true)
        {
            float jumpPower = 7f;
            
            if (superJumpsRemaining > 0)
            {
                jumpPower *= 1.2f;
                
            }
            rigidbodyComponent.AddForce(Vector3.up * jumpPower, ForceMode.VelocityChange);
            jumpKeyWayPressed = false;
        }

        
        


    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.layer == 7 )
        {
            
            Destroy(other.gameObject);
            superJumpsRemaining++;
            runSpeed++;
            


        }
    }














    // private void OnCollisionEnter(Collision collision){isGrounded = true;}
    // private void OnCollisionExit(Collision collision){isGrounded = false;} 
}
