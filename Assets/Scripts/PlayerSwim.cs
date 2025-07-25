using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerSwim : MonoBehaviour
{
    public float swimSpeed = 5f; // the speed at which the player swims
    public float waterLevel = 0f; // the height of the water level
    private bool isSwimming = false; // a flag to determine whether the player is swimming or not
    private FirstPersonController fpsController; // a reference to the First Person Controller component on the player

    private void Start()
    {
        fpsController = GetComponent<FirstPersonController>();
    }

    void Update()
    {
        // check if the player is underwater
        if (transform.position.y < waterLevel)
        {
            isSwimming = true;
        }
        else
        {
            isSwimming = false;
        }

        // if the player is swimming, move them up
        if (isSwimming)
        {
            transform.Translate(Vector3.up * swimSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // if the player enters water, check if it has the Water tag
        if (other.gameObject.CompareTag("Water"))
        {
            waterLevel = other.gameObject.transform.position.y;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // if the player exits water, reset the water level
        if (other.gameObject.CompareTag("Water"))
        {
            waterLevel = 0f;
        }
    }
}
