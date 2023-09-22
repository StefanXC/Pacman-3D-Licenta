using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SalveazaDate
{
    public static void SalveazaProgres(PacmanStats pacman)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/Date.txt";
        FileStream stream = new FileStream(path, FileMode.Create);

        PacmanData data = new PacmanData(pacman);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static PacmanData IncarcaProgres()
    {
        string path = Application.persistentDataPath +"/Date.txt";
           if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PacmanData data= formatter.Deserialize(stream) as PacmanData;
            stream.Close();

            return data;
        }
           else
        {
            Debug.LogError("Fisierul <Date> nu a fost gasit" + path);
            return null;
        }
    }

}
