using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DataInfo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class dataManage : MonoBehaviour
{
    private string pathTheData;

    public void Initialize()
    {
        //?
    }

    public void saveData(userData userdata)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(pathTheData);

        userData data = new userData();
        //기타 userData의 정보들 (레벨체력등)
        Heart heart = new Heart();
        item Item = new item();


        bf.Serialize(file, data);
        file.Close();
    }


    public userData loadTheData()
    {
        if (File.Exists(pathTheData))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(pathTheData, FileMode.Open);
            userData data = (userData)bf.Deserialize(file);
            file.Close();

            return data;
        }
        else
        {
            userData data = new userData();

            return data;
        }
    }
}
