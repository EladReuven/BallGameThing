using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class PlayerData
{
    public int hp;
    public string name;
    public int XP;
    public GameObject objBeingSaved;

}
public class JsonExample : MonoBehaviour
{
    [SerializeField]
    GameObject objToSave;

    [SerializeField]
    PlayerStats playerStats;

    void Start()
    {
        
        //creating data class instance
        PlayerData mPlayerData = new PlayerData();
        mPlayerData.hp = playerStats.CurrentHP;
        mPlayerData.name = "notToday";
        mPlayerData.XP = 5000;
        mPlayerData.objBeingSaved = objToSave;

        //turn obj into json string
        string json = JsonUtility.ToJson(mPlayerData);


        //write json to local file (using System.IO)
        //File.WriteAllText(@"C:\Tiltan\Unity\BallGameThing\simple 3d platformer test\json.txt", json);
        File.WriteAllText(Application.persistentDataPath + @"\jsonPersist.txt", json);


        //print to log
        Debug.Log(json);

    }


    void Update()
    {
        
    }
}
