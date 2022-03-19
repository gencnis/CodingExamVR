using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Replace this game object with another
/// 
/// @author Nisanur Genc
/// </summary>
public class Transformation : MonoBehaviour
{

    public GameObject coin;
    public GameObject strawberry;


    // Start is called before the first frame update
    void Start()
    {
	coin.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void getCoin()
    {
      	Destroy(strawberry);
	coin.SetActive(true);
    }
}
