using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjconsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidate Candi = new Candidate();

            Console.WriteLine("enter your Candidate S.no");
            Candi.Sno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your candidate Name");
            Candi.Name = Console.ReadLine();

            Console.WriteLine("Enter your candidate PhoneNumber");
            Candi.phone = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter Candidate SuperId");
            Candi.SuperId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter candidate Email");
            Candi.Email = Console.ReadLine();

            Console.WriteLine("Enter candidate Adress");
            Candi.Adress = Console.ReadLine();

            Console.WriteLine("Candidate Sno is : " + Candi.Sno + " " + "\nCandiadte Name is :" + Candi.Name + " " + "\nCandiadte Phonenumber is : " + Candi.phone + " " + "\nCandidate SuperId is :" + Candi.SuperId + " " + "\nCandidate Email Id is : " + Candi.Email + " " + "\nCandidate Adress is : " + Candi.Adress);
            Console.ReadLine();



                
        }
        public class Candidate
        {
            public int Sno;
            public String Name;
            public long phone;
            public int SuperId;
            public string Email;
            public string Adress;


        }
    }
} 
