using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Mid_Term
{
    class fileIO
    {
        public static void writeFile(string myFileName, string myString)
        {
            //declare a StreamWriter object
            StreamWriter sw;

            //create the streamwriter and set the file and how the file is opened
            sw = new StreamWriter(File.Open(myFileName, FileMode.OpenOrCreate));

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


        public static string[] readFile(string myfilename)
        {
            string[] stuff = new string[20];
            try
            {
                //declare a StreamWriter object
                StreamReader sr;

                //Create object and set file and how file is to be handled
                sr = new StreamReader(File.Open(myfilename, FileMode.Open));
                //stuff = "";
                try
                {
                    int index = 0;
                    while (!sr.EndOfStream)
                    {
                        //Read file from top to bottom and store it in string var
                        stuff[index] = sr.ReadLine();
                        index++;
                        // myFileName = sr.ReadToEnd();

                    }
                }
                finally
                {
                    sr.Close(); //Close the text file with or without errors
                }

            }
            catch (Exception exc)
            {
                stuff[0] = "ERROR: " + exc.Message; //Store error msg 
                // return x;
            }
            return stuff;   //Return the string for use by the driver program
        }

        public static string UpdateFile(string myfilename, List<string> order_type, List<string> pizza_size, 
             List<string> pep, List<string> sau, List<string> mtb, List<string> ham, List<string> ppr, 
            List<string> oni, List<string> olv, List<string> spg, List<string> pin, List<string> bbq, 
            List<string> xch, List<string> slp, List<string> Fname, List<string> Lname)
        {
            //find & store the value for the number of records
            int NumofRecs = Fname.Count - 1;
            //int Index = 0;

            //declared variable for function use
            string myString = "";
            string strFeedback = "";


            StreamWriter sw;

            try{
                //delete data file
                File.Delete(myfilename);

                //wishful thinking
                strFeedback = "Record Update Successfully.";


                //rewrite data file
                sw = new StreamWriter(File.Open(myfilename, FileMode.OpenOrCreate));

                for (int Ctr = 0; Ctr <= NumofRecs; Ctr++)
                    {
                        //set starting point for data creation 
                        sw.BaseStream.Seek(0, SeekOrigin.End);

                        //rewrite data file
                        myString = order_type[Ctr] + "," + pizza_size[Ctr] + "," + pep[Ctr] + "," + sau[Ctr] + "," + mtb[Ctr] + "," +
                            ham[Ctr] + "," + ppr[Ctr] + "," + oni[Ctr] + "," + olv[Ctr] + "," + spg[Ctr] + "," + pin[Ctr] + "," +
                            bbq[Ctr] + "," + xch[Ctr] + "," + slp[Ctr] + "," + Fname[Ctr] + "," + Lname[Ctr];

                        sw.WriteLine(myString);
                    }
                sw.Flush();

                sw.Close();
                }
                //send error message if necessary
                catch (Exception err)
            {
                    string x = err.Message;
                    strFeedback = "ERROR: " + x;
            }
            return strFeedback;
        }
    } 
}