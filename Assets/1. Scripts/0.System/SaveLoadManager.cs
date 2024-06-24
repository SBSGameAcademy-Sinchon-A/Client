using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadManager : MonoBehaviour
{
    public UserData userData ;
    GameData gameData; 

    void Start()
    {
        userData = new UserData(1);

        Debug.Log(userData.userID);
    }

    public void Save()
    {
        // !! 유저데이터 , 게임 데이터 제작 후 바이너리 저장 호출

        SaveBinary();
    }

    public void SaveBinary()
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();

        string saveFileName = "UserData";
        string savePath = Application.persistentDataPath + "/" + saveFileName;

        FileStream fileStream = new FileStream(savePath, FileMode.Create);
        userData = new UserData(1 /*!! 유저 아이디 불러오기 */ );

        binaryFormatter.Serialize(fileStream, userData);
        fileStream.Close();

    }

    public void LoadBianry()
    {

    }
}
