using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserAccount : MonoBehaviour
{
    public string username {get; set; }
    public string userpasswd {get; set;}

    public UserAccount(string username, string userpasswd)
    {
        this.username = username;
        this.userpasswd = userpasswd;
    }
}
