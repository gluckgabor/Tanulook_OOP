using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            int askedPerformanceGrade;
            List<Student> LStudent = new List<Student>();
            ArrayList performanceGrade = new ArrayList();
            
            bool vigyunkFelMeg = false;
            bool kiIratas = false;

            string kilistazasValasz;
            string vigyunkFelValasz;

            do
            {
                /*a felhasználó beírhat diákokat*/
                Console.WriteLine("Hogy hivjak a diakot?");                
                student.SetName(Console.ReadLine());

                /*és azt hogy ők milyen osztályzatokat kaptak.*/
                Console.WriteLine("Milyen osztályzatot kapott a diák? Randomolunk egy osztályzatot");
                Random rnd = new Random();
                askedPerformanceGrade = rnd.Next(1, 6);
                Console.WriteLine($"A randomolt osztályzat: " + askedPerformanceGrade);
                student.SetPerformanceGrade(askedPerformanceGrade); //Convert.ToInt32(Console.ReadLine()

                Console.WriteLine("Vigyünk fel még diákot? i - igen, n - nem");
                vigyunkFelValasz = Console.ReadLine();
                if (vigyunkFelValasz == "i")
                {
                    vigyunkFelMeg = true;
                }
                else { vigyunkFelMeg = false; }

                student.Add(student);


            } while (vigyunkFelMeg);



            Console.WriteLine("Azt válaszoltad, hogy nem szeretnél több diákot felvinni");

            /*             
            ki tudjátok listázni hogy milyen diákokat vett már fel és hogy nekik milyen osztályzataik vannak és azoknak mennyi az átlaga.
            */
            Console.WriteLine("Szeretnéd a felvitt adatokat kilistáztatni? i - igen, n - nem");
            kilistazasValasz = Console.ReadLine();

            if (kilistazasValasz == "i")
            {
                Console.WriteLine(Student.GetDescription());
                Console.ReadLine();
            }
        }
    }
}

