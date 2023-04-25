using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerMovementHelp : MonoBehaviour
{
    private XROrigin XROrigin;
    private CharacterController characterController;
    private CharacterControllerDriver driver;
    private AudioSource footsteps;

    // Start is called before the first frame update
    void Start()
    {
        XROrigin = GetComponent<XROrigin>();
        characterController = GetComponent<CharacterController>();
        driver = GetComponent<CharacterControllerDriver>();
        footsteps = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCharacterController();

        if(characterController.isGrounded && characterController.velocity.magnitude >=2 && !footsteps.isPlaying)
        {
            footsteps.volume = Random.Range(0.8f, 1);
            footsteps.pitch = Random.Range(0.8f, 1.1f);
            footsteps.Play();
        }
    }
    /// <summary>
    /// Updates the <see cref="CharacterController.height"/> and <see cref="CharacterController.center"/>
    /// based on the camera's position.
    /// </summary>
    protected virtual void UpdateCharacterController()
    {
        if (XROrigin == null || characterController == null)
            return;

        var height = Mathf.Clamp(XROrigin.CameraInOriginSpaceHeight, driver.minHeight, driver.maxHeight);

        Vector3 center = XROrigin.CameraInOriginSpacePos;
        center.y = height / 2f + characterController.skinWidth;

        characterController.height = height;
        characterController.center = center;
    }
}
