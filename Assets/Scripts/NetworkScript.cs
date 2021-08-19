using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
public class NetworkScript : MonoBehaviour
{
    private GameObject detailsPanel;
    private Text email;
    private Text password;
    private Text username;
    private Text emailSignup;
    private Text phone;
    private Text firstName;
    private Text lastName;
    private Text passwordSignup;
    private Text repasswordSignup;
    private GameObject loginPanel;
    public string responseLogin;
    public string responseSignup;
    public bool inProfile = false;
    public bool signingUp = false;
    private GameObject signupbutton;
    
    // Start is called before the first frame update
    void Start()
    {
        signupbutton = GameObject.Find("Signin");
        detailsPanel = GameObject.Find("DetailsPanel");
        loginPanel = GameObject.Find("LoginPanel");
        email = GameObject.Find("TextEmail").GetComponent<Text>();
        password = GameObject.Find("TextPassword").GetComponent<Text>();
        username = GameObject.Find("textusername").GetComponent<Text>();
        phone = GameObject.Find("textphone").GetComponent<Text>();
        emailSignup = GameObject.Find("textemailsignup").GetComponent<Text>();
        firstName = GameObject.Find("textfirstname").GetComponent<Text>();
        lastName = GameObject.Find("textlastname").GetComponent<Text>();
        passwordSignup = GameObject.Find("textpassword").GetComponent<Text>();
        repasswordSignup = GameObject.Find("textrepassword").GetComponent<Text>();
        //StartCoroutine(Login());
        StartCoroutine(Signup());
    }

    /*IEnumerator Login()
    {
        if(inProfile == false)
        {
            WWWForm loginDetails = new WWWForm();

            loginDetails.AddField("email", email.text);
            loginDetails.AddField("password", password.text);
            using (var uwr = UnityWebRequest.Post("http://127.0.0.1:8000/account/token/login", loginDetails))
            {
                
                yield return uwr.SendWebRequest();

                string auth_token = uwr.downloadHandler.text;
                //Debug.Log(auth_token);

            }
        }
    }*/

    IEnumerator Signup()
    {
            username.text = "prakke";
            phone.text = "9910140920";
            firstName.text = "nabh";
            lastName.text = "rana";
        emailSignup.text = "500065751@stu.upes.ac.in";
        passwordSignup.text = "YNRana16";
        repasswordSignup.text = "YNRana16";

            WWWForm signupDetails = new WWWForm();
            signupDetails.AddField("Username", username.text);
            signupDetails.AddField("Phone", phone.text);
            signupDetails.AddField("First name", firstName.text);
            signupDetails.AddField("Last name", lastName.text);
            signupDetails.AddField("Email", emailSignup.text);
            signupDetails.AddField("Password", passwordSignup.text);
            signupDetails.AddField("Re password", repasswordSignup.text);
        Debug.Log("connecting1");
            using (var uwrSignup = UnityWebRequest.Post("http://127.0.0.1:8000/account/users", signupDetails))
            {
                
                yield return uwrSignup.SendWebRequest();

                string resusername = uwrSignup.downloadHandler.text;
                Debug.Log("connecting");
            }
        }


    // Update is called once per frame
    void Update()
    {
        if(signupbutton.activeInHierarchy == false)
        {
            signingUp = true;
        }
    }
}
