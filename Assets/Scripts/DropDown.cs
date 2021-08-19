using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDown : MonoBehaviour
{
    private Dropdown street;
    public int valueStreet;
    // Start is called before the first frame update
    void Start()
    {
        street = GetComponent<Dropdown>();
        Debug.Log("Starting Dropdown Value : " + street.value);
    }

    // Update is called once per frame
    void Update()
    {
        valueStreet = street.value;
        //Debug.Log("Updated Dropdown value: " + valueStreet);
    }
}
