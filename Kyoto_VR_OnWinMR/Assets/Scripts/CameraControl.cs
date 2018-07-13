using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{

    GameObject Player;
    GameObject mainCamera;
    void Start()
    {
        Player = GameObject.Find("Player");
        mainCamera = GameObject.Find("Main Camera");
    }

    void Update()
    {

        mainCamera.transform.position = new Vector3(Player.transform.position.x - 100, Player.transform.position.y, Player.transform.position.z );

    }
}