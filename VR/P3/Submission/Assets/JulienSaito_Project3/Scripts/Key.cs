using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject keyPoofPrefab;
    public Door door;

    private Vector3 initialPosition;
    private float rotationY;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
	{
        //rotate the key
        rotationY += Time.deltaTime * 100;
        transform.rotation = Quaternion.Euler(0, rotationY, 0);

        //translate up and down
        transform.position = initialPosition + new Vector3(0, Mathf.Sin(Time.time) / 2 , 0);
    }

	public void OnKeyClicked()
	{

        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        Object.Instantiate(keyPoofPrefab, transform.position, Quaternion.LookRotation(Vector3.up));

        // Call the Unlock() method on the Door
        door.Unlock();

        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(gameObject, 0.5f);
    }

}
