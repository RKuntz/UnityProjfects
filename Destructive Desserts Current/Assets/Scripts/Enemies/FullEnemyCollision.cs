using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullEnemyCollision : MonoBehaviour
{

    public AudioSource[] vocals;
    private AudioSource weaponSound;
    public bool isDead = false;
    public Collider meshCollider;
    private float timer;
    private EnemyMovement movement;
    // Start is called before the first frame update
    void Start()
    {
        setRigidBodyState(true);
        setColliderState(false);
        movement = gameObject.GetComponent<EnemyMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            die();
            timer += Time.deltaTime;
            if(timer >= 3)
            {
                Destroy(gameObject);
            }
        }
    }

    
    private void OnCollisionEnter(Collision weapon)
    {
        float weaponSpeed = 0;
        if (weapon.gameObject.GetComponent<Rigidbody>() != null)
        {
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
            die();
        }
    }

    public void die()
    {
        setRigidBodyState(false);
        setColliderState(true);
        isDead = true;
        movement.stunned = true;

    }

    void setRigidBodyState(bool state)
    {
        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();

        foreach(Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = state;
        }
    }

    void setColliderState(bool state)
    {
        Collider[] colliders = GetComponentsInChildren<Collider>();

        foreach (Collider collider in colliders)
        {
            collider.enabled = state;
        }
        meshCollider.enabled = !state;
    }
}
