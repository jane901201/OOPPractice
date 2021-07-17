using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D characterController;
    private PlayerActionController controller;
    private Animator animator;

    float horizontalMove = 0f;
    float runSpeed = 20f;
    bool jump = false;

    private void Awake()
    {
        controller = new PlayerActionController();
        animator = gameObject.GetComponent<Animator>();
    }

    private void OnEnable()
    {
        controller.Enable();
    }
    private void OnDisable()
    {
        controller.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        float movementInput = controller.Land.Move.ReadValue<float>();
        Vector3 currectPosition = transform.position;
        currectPosition.x += movementInput * runSpeed * Time.deltaTime;
        horizontalMove = movementInput * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(movementInput * runSpeed));

        if(controller.Land.Jump.ReadValue<float>() > 0f)
        {
            jump = true;
            animator.SetBool("IsJumping", jump);
        }

        if(controller.Land.Attack.triggered)
        {
            Debug.Log("Attack");
        }

    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    private void FixedUpdate()
    {
        characterController.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
       
    }


}
