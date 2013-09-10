using System;
using System.Linq;
using System.Net;
//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
//and stores it the current directory. Find in Google how to download files in C#. Be sure to catch all 
//exceptions and to free any used resources in the finally block.

    class DownloadFileFromWeb
    {
        static void Main()
        {
            WebClient webClient = new WebClient();
            using (webClient)
            {
                try
                {
                    webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"..\..\Logo-BASD.jpg");
                    //this row will be executed only if downwoad is successfull
                    Console.WriteLine("The file is downloaded");
                }
                catch (ArgumentNullException ex1)
                {
                    Console.WriteLine("{0}",ex1.Message);
                }
                catch (System.Net.WebException ex2)
                {
                    Console.WriteLine("{0}", ex2.Message);
                }
                catch (System.NotSupportedException ex3)
                {
                    Console.WriteLine("{0}", ex3.Message);
                }
               
            }
            
        }
    }

