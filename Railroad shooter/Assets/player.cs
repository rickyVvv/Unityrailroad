using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [Tooltip("Inms^-1")] [SerializeField] float Speed=20f;
    [Tooltip("In m")] [SerializeField] float xRange=8f;
    [Tooltip("In m")] [SerializeField] float yRange=5f;
    [SerializeField] float positionPitchFactor = -3f;
    [SerializeField] float controlPitchFactor = -5f;
    [SerializeField] float positionYawFactor = 3f;
    [SerializeField] float controlRollFactor = -3;

    float xThrow,yThrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        ProcessTranslation();
        ProcessRotation();

    }
        private void ProcessRotation(){
        float pitchDueToPosition = transform.localPosition.y * positionPitchFactor;
        float pitchDueToControlThrow = yThrow * controlPitchFactor;
        float pitch = pitchDueToPosition + pitchDueToControlThrow;

        float yaw = transform.localPosition.x * positionYawFactor;

        float roll = xThrow * controlRollFactor;

        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
    }
    private void ProcessTranslation(){
        float xThrow = Input.GetAxis("Horizontal");
        float yThrow = Input.GetAxis("Vertical");

        float xOffset = xThrow * Speed ;
        float yOffset = yThrow *  Speed ;

        float xPos = transform.localPosition.x + xOffset;
        float yPos = transform.localPosition.y + yOffset;

        float POSITION= Mathf.Clamp(xPos, -xRange, xRange); //this will stop the position of the ship from exceeding -8 or 8 on the x value
        float POSITIONy= Mathf.Clamp(yPos, -yRange, yRange); 

        transform.localPosition= new Vector3(POSITION, POSITIONy, transform.localPosition.z); // this is so we dont change our x or y position
    }
}
