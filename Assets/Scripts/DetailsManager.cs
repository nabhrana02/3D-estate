using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailsManager : MonoBehaviour
{
    private SimManager simManager;
    private Text displayDetails;
    // Start is called before the first frame update
    void Start()
    {
        simManager = GameObject.Find("SimManager").GetComponent<SimManager>();
        displayDetails = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        displayDetails.text = simManager.houseText.text;
    }
}



