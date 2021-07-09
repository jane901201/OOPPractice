using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerTest : MonoBehaviour
{
    private PlayerActionController actionController;
    private float speed = 1.0f, jumpSpeed;

    private void Awake()
    {
        actionController = new PlayerActionController();
    }

    private void OnEnable()
    {
        actionController.Enable();
    }

    private void OnDisable()
    {
        actionController.Disable();
    }

    void Start()
    {
        
    }

    void Update()
    {
        float movementInput = actionController.Land.Move.ReadValue<float>();
        Vector3 currectPosition = transform.position;
        currectPosition.x += movementInput * speed * Time.deltaTime;
    }
}
