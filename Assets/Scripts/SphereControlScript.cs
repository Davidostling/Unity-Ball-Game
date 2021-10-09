// Import some external libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Declare a new class, which inherits functionality from the parent class MonoBehaviour
public class SphereControlScript : MonoBehaviour
{
    // Object variables are declared here!
    // if this was Python, it would look something like
    // def __init__(self):
    // self.forceFactor = 1.0

    public float forceFactor = 1.0f;
    public Text scoreUIText;
    

    private int pickupCounter;
    // Start is called before the first frame update 
    void Start()
    {
        
        pickupCounter = 0;
    }

    // Update is called once per frame

    void Update()
    {
        // Because this script runs on the PlayerSphere, the following line
        // will fetch the Rigidbody component from the PlayerSphere.
        // RigidBody can of course be changed to something else, but right
        // now, we actually need it!
        scoreUIText.text = "SCORE: " + pickupCounter;
        Rigidbody rigidBody = GetComponent<Rigidbody>();

        // This is of course one way of reading input control. Go to the Unity 
        // documentation, and read about the Input system. And yes, the default
        // configuration will make the sphere controllable with both the arrow keys
        // as well as a game pad (like an XBox one game pad). Pretty neat!
        float xDir = Input.GetAxis("Horizontal");
        float zDir = Input.GetAxis("Vertical");

        // We create a new force vector from the inputs above: 
        Vector3 force = new Vector3(xDir, 0, zDir);

        // And we add a constant force to the rigidBody, which is a component
        // of the sphere, hence, pushing it around!
        rigidBody.AddForce(force, ForceMode.Force);
    }
    
    void OnTriggerEnter(Collider other){
        pickupCounter+=1;
        Debug.Log(pickupCounter);
        
    }

    public int getPickupCounter(){
    return pickupCounter;
    }
}