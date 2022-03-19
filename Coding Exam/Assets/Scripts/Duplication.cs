using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Duplicate the object
/// 
/// @author Nisanur Genc
/// </summary>
public class Duplication : MonoBehaviour
{
    public GameObject copy;
    

    // Start is called before the first frame update
    void Start()
    {
    // this line of code sets the copy strawberry to false so it is invisible at the beginning 
	copy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void duplicate()
    {
        // it sets it true so we can now see the duplicate strawberry
	    copy.SetActive(true);
    }
}
