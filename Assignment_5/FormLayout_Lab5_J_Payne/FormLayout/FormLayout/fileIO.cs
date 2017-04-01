using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FormLayout
{
    class fileIO
    {
        public static void writeFile(string myFillName, string myString)
        {
            //declare a StreamWriter object
            StreamWriter sw;

            //create the streamwriter and set the file and how the file is opened
            sw = new StreamWriter(File.Open(myFillName, FileMode.OpenOrCreate));

            // string results = "OK";

            try
            {
                //place the cursor at the first cloumn, on the row after the last record
                sw.BaseStream.Seek(0, SeekOrigin.End);

                //write the data to the bottom of the file
                sw.WriteLine(myString);

                //force the write, save the file, clear the buffer
                sw.Flush();
            }
                catch (Exception err)
            {
                //display error message if necessary
                string x = err.Message;
            }

            finally
            {
                //close the file whether or not there was an error
                sw.Close();
            }


        }
    }
}
