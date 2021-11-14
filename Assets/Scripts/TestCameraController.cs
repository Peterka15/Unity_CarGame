using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCameraController : MonoBehaviour
{
    
    private Transform player;

    private float yOffset = 3.5f;
    private float zOffset = -10f;
    private float xOffset = 0f;
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector4(player.position.x + xOffset, player.position.y + yOffset, player.position.z + zOffset);
    }
}
