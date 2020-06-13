using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [Tooltip("Inms^-1")] [SerializeField] float xSpeed=4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xThrow = Input.GetAxis("Horizontal");
        float xOffset = xThrow * xSpeed * Time.deltaTime;
        float xPos = transform.localPosition.x + xOffset;
        transform.localPosition= new Vector3(xPos, transform.localPosition.y, transform.localPosition.z); // this is so we dont change our x or y position
        
    }
}
