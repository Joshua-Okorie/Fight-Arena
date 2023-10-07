using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterAnimation playerAnim;
    private Rigidbody playerRigid;
    private Vector3 moveDirection;
    public float speed = 10f;
    


    private void Start()
    {
        playerAnim = GetComponent<CharacterAnimation>();
        playerRigid = GetComponent<Rigidbody>();

    }

    private void Update()
    {
      AnimateWalk();
      HandleRotation();

    }

    private void FixedUpdate()
    {
        HandleMovementInput();
    }

    private void HandleMovementInput()
    {
        playerRigid.velocity = new Vector3 (
            Input.GetAxisRaw("Horizontal") * (speed),
            playerRigid.velocity.y,
            playerRigid.velocity.z);
       
        

    }
    
    private void HandleRotation()
    {
        if(Input.GetAxisRaw("Horizontal") > 0f)
        {
            transform.rotation = Quaternion.Euler(0f, Mathf.Abs(90f), 0f);
        }

        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            transform.rotation = Quaternion.Euler(0f, -Mathf.Abs(90f), 0f);
        }
    }

    void AnimateWalk()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            playerAnim.Walk(true);
        }

        else
        {
            playerAnim.Walk(false);
        }
    }

}

