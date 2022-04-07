using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveLoadGameManager
{
    public static void SavePlayerStats(DatesP player) {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/playerstats.kof";
        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData playerStats = new PlayerData(player);
        formatter.Serialize(stream, playerStats);
        stream.Close();
    }

    public static PlayerData LoadPlayerStats() {
        string path = Application.persistentDataPath + "/playerstats.kof";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerData player = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return player;
        }
        else {
            Debug.Log("The slot does not exist in this o path:" + path);
            return null;
        }
    }
}
