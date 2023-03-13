using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{

    private AudioSource weaponSound;
    private void OnCollisionEnter(Collision weapon)
    {
        float weaponSpeed = 0;
        if(weapon.gameObject.GetComponent<Rigidbody>() != null) {
            //get the speed of the object at the time of collision
            weaponSpeed = weapon.gameObject.GetComponent<Rigidbody>().velocity.magnitude;
            Debug.Log(weaponSpeed.ToString());
        }

        
        
        

        //check if the colliding object has the Weapon tag
        if (weapon.gameObject.tag == "Weapon" && weaponSpeed >= 3)
        {
            weaponSound = weapon.gameObject.GetComponent<AudioSource>();
            weaponSound.Play();
            Destroy(this.gameObject);
        }
    }
}
