using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    float x = 0f;
    float z = 0f;

    CharacterController controller;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal") * speed;
        z = Input.GetAxis("Vertical") * speed;
        Vector3 direction = new Vector3(x, 0, z);

        controller.SimpleMove(direction);
    }
}
