using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
  [SerializeField] private KeyCode flapKey = KeyCode.Space;
  BirdPhysics birdPhysics = null;

  // Use this for initialization
  void Awake () 
  {
    birdPhysics = transform.root.GetComponentInChildren<BirdPhysics>();
  }
	
	// Update is called once per frame
	void Update () 
  {
    if (Input.GetKeyDown(flapKey))
      birdPhysics.Flap();

  }
}
