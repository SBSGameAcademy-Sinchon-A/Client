using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class UserData : MonoBehaviour
{
    public int userID;
    public string userName;

    public UserData(int userId)
    {
        this.userID = userID;
       
    }
}
