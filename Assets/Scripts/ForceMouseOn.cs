using UnityEngine;

public class ForceMouseOn : MonoBehaviour
{
    void OnEnable()
    {
        // Ensure the cursor is visible
        Cursor.visible = true;

        // Ensure the cursor is not locked
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        // Redundantly enforce the state each frame in case something else changes it
        if (!Cursor.visible)
            Cursor.visible = true;

        if (Cursor.lockState != CursorLockMode.None)
            Cursor.lockState = CursorLockMode.None;
    }
}
