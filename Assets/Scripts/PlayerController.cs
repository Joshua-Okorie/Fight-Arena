using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator playerAnim;
    private Vector3 moveDirection;
    public float speed = 10f;
    private bool punch = false;
    //private bool kick = false;

    private void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    private void Update()
    {
        HandleMovementInput();
        UpdateAnimator();
    }

    private void HandleMovementInput()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        moveDirection = new Vector3(horizontalInput, 0, verticalInput);

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0.0f) * speed * Time.deltaTime;

        // Update the object's position
        transform.Translate(movement, Space.World);

        // Ensure the object can move in both positive and negative X directions
        float newX = Mathf.Clamp(transform.position.x, -20.0f, 20.0f); // Adjust the range as needed
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);

    }

    private void UpdateAnimator()
    {
        if (moveDirection != Vector3.zero)
        {
            RotateCharacter();
            SetAnimatorSpeed(moveDirection.magnitude * speed);
        }
        else
        {
            SetAnimatorSpeed(0f);
        }

        if (Input.GetKey(KeyCode.J))
        {
            punch = true ;
            SetAnimatorPunch(punch);
        }

        else 
        {
            SetAnimatorPunch(false);
        }

        /* if (Input.GetKeyDown(KeyCode.K))
        {
            kick = true ;
            SetAnimatorKick(kick);
        }

        else 
        {
            SetAnimatorKick(false);
        }
        */
    }

    private void RotateCharacter()
    {
        transform.LookAt(transform.position + moveDirection);
    }

    private void SetAnimatorSpeed(float speedValue)
    {
        playerAnim.SetFloat("Speed", speedValue);
    }

    private void SetAnimatorPunch(bool punchKey)
    {
        playerAnim.SetBool("PunchKey", punchKey);
    }

   /* private void SetAnimatorKick(bool kickKey)
    {
        playerAnim.SetBool("KickKey", kickKey);
    }
    */
}

