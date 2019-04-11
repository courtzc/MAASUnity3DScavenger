using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float jumpSpeed = 10f;
    public float gravity = 10f;
    private int count;
    public Text countText;
    public Text winText;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;


    // Start is called before the first frame update
    void Start()
    {
        // set collectable count to 0
        count = 0;
        countText.text = "Collectables found: " + count.ToString();

        // put your player at the opening of the field
        transform.position = new Vector3(103, 6, 54);
        controller = GetComponent<CharacterController>();
        
        // drop to ground
        gameObject.transform.position = new Vector3(0, 5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the character is on the ground
        if (controller.isGrounded)
        {
            // Work out which direction you'll move
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * speed;

            // Check if the player is jumping
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }

            // Rotate the player to the left and right
            transform.Rotate(0, Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0);

        }

        // Apply gravity
        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);

        // Move the player
        controller.Move(moveDirection * Time.deltaTime);

    }

    void OnTriggerEnter(Collider other)
    {
        // Check the provided Collider2D parameter other to see if it is tagged "Collectable"
        if (other.gameObject.CompareTag("Collectable"))
        {
            Destroy(other.gameObject);
            count += 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        // Update how many collectables are found
        countText.text = "Collectables found: " + count.ToString();

        // If all collectables are found, update winText
        if (count >= 9)
        {
            winText.text = "You've won!";
        }
    }
}
