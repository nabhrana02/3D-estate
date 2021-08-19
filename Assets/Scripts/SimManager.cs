using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimManager : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject mainplayer;
    private GameObject first;
    private GameObject firstPanel;
    private GameObject secondPanel;
    //private GameObject thirdpanel;
    private GameObject second;
    private GameObject house;
    public Text houseText ;
    private GameObject third;
    private DropDown scriptDropdown;
    private GameObject loginPanel;
    private bool credentials;
    private Text username;
    private Text password;
    void Start()
    {
        mainplayer = GameObject.Find("Player");
        first = GameObject.Find("Street 1");
        firstPanel = GameObject.Find("Panel1");
        second = GameObject.Find("Street 2");
        secondPanel = GameObject.Find("Panel2");
        third = GameObject.Find("Street3");
        
        scriptDropdown = GameObject.Find("Dropdown").GetComponent<DropDown>();
        houseText = GameObject.Find("House1").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (scriptDropdown.valueStreet == 0)
        {
            first.SetActive(true);
            firstPanel.SetActive(true);
            second.SetActive(false);
            secondPanel.SetActive(false);
            third.SetActive(false);
        }

        if (scriptDropdown.valueStreet == 1)
        {
            first.SetActive(false);
            firstPanel.SetActive(false);
            second.SetActive(true);
            secondPanel.SetActive(true);
            third.SetActive(false);
        }

        if (scriptDropdown.valueStreet == 2)
        {
            first.SetActive(false);
            second.SetActive(false);
            third.SetActive(true);
            secondPanel.SetActive(false);
            firstPanel.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        RaycastHit infogo;
        if (Physics.Raycast(mainplayer.transform.position, mainplayer.transform.forward, out infogo,60.0f))
        {
            house = GameObject.Find(infogo.collider.name);
            houseText = house.GetComponent<Text>();
            Debug.Log("Hitting a collider " + $"{houseText.text}");
            
        }
        else
        {
            //Debug.Log("Not Hitting a Collider");
        }
    }
}
