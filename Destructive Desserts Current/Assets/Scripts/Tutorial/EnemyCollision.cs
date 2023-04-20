using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{

    public AudioSource[] vocals;

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

            int soundToPlay = Random.Range(0, vocals.Length);

            vocals[soundToPlay].Play();

            weaponSound = weapon.gameObject.GetComponent<AudioSource>();
            weaponSound.pitch = (Random.Range(0.95f, 1.05f));
            weaponSound.Play();
            Destroy(this.gameObject);
        }
    }
}
