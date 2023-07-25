using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BItMyName
{
    class Cooridnates
    {
        public void Save_To_File(string fileName, string[] text)
        {

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach(string wiersz in text)
                {
                    sw.WriteLine(wiersz);
                }

            }

        }

        public void Save_To_File_Anim(string fileName, string[] text)
        {

            List<string> cordy = new List<string>();

            using (StreamReader sr = new StreamReader(fileName))
            {
                string wiersz;
                while ((wiersz = sr.ReadLine()) != null)
                    cordy.Add(wiersz);
            }



            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach(string wiersz in cordy.ToArray())
                {
                    sw.WriteLine(wiersz);
                }

                foreach (string wiersz in text)
                {
                    sw.WriteLine(wiersz);
                }

            }

        }

        public string[] Read_From_File(string fileName)
        {
            

            List<string> cordy = new List<string>();

            using (StreamReader sr = new StreamReader(fileName))
            {
                string wiersz;
                while ((wiersz = sr.ReadLine()) != null)
                    cordy.Add(wiersz);
            }

            return cordy.ToArray();

        }

        public string[] Read_From_File_Anim(string fileName)
        {


            List<string> cordy = new List<string>();
            using (StreamReader sr = new StreamReader(fileName))
            {
                string wiersz;
                while ((wiersz = sr.ReadLine()) != null)
                {
                    if(wiersz != "")
                    cordy.Add(wiersz);
                    
                }
            }

            return cordy.ToArray();

        }

        public int Matrix_Check(string fileName)
        {


            List<string> cordy = new List<string>();
            int k = 0;

            using (StreamReader sr = new StreamReader(fileName))
            {
                string wiersz;
                while ((wiersz = sr.ReadLine()) != "")
                {
                    k++;
                }
            }

            return k;

        }


    }
}
