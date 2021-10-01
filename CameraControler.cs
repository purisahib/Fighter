using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    [SerializeField] private Vector2 mouseValue;
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 rot;
    // Update is called once per frame
    void Update()
    {
        rot = gameObject.transform.rotation.eulerAngles;
        mouseValue.x = Input.GetAxis("Mouse X");
        mouseValue.y = Input.GetAxis("Mouse Y");
        if(50f >= rot.x && rot.x >= 0f)
            transform.Rotate(mouseValue.y, 0f, 0f);
        
        player.transform.Rotate(0f,mouseValue.x, 0f);
        
    
    }
}
