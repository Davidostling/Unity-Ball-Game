using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickupScript : MonoBehaviour
{

    public AudioSource Pickup;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        Pickup = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other){
    //This message will appear in the console in the bottom of the Unity editor!
    
    Debug.Log("Something entered!" + other.ToString() + " at time: " + Time.time.ToString());

    //Single out only collisions with the player..
    if (other.gameObject.tag == "Player"){
    // .. so we know we are dealing with a trigger from the Player sphere!
    // Task: Move the Pickup to a random location inside the play area.
    
    //(1) create a new Vector3 with a new random location (preferebly reachable!)
        
        Vector3 position = new Vector3(Random.Range(-4.0f, 4.0f), 0.2f, Random.Range(-4.0f,4.0f));
        Pickup.Play();
    //(2) set the position of the pickup (this actual object) transform to
    // your newly created vector.
    
        transform.position = position;
       
        
        

    }
}
}
