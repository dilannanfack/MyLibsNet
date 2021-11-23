using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyLibs.Serialisation
{
    public class Serializer
    {

        public void Serialize<T>(T data, String path)
        {
            using (StreamWriter file = new StreamWriter(path, true))
            {
                BinaryFormatter bf = BinaryFormatter();
                bf.Serialize(file.BaseStream, data);
            }
        }

        private BinaryFormatter BinaryFormatter()
        {
            throw new NotImplementedException();
        }

        public T Deserialize<T>(string path)
        {
            using (StreamReader file = new StreamReader(path, true))
            {
                BinaryFormatter bf = BinaryFormatter();
                return (T)bf.Deserialize(file.BaseStream);
            }
        }
    }
}
