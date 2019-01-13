using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Job_Candidate_System
{
    class MyFile
    {
        public MyFile() { }

        public void ToTxt(object o)   
        {          
            FileStream fs = new FileStream(@"candidatesfile.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            fs.Close();
            StreamWriter sw = new StreamWriter(@"candidatesfile.txt", true, Encoding.ASCII);
            //sw.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            sw.WriteLine(o);
            sw.Close();           
        }


    }
}
