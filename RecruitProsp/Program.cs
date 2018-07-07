using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitProsp  
{
    class Program
    {
        static void Main(string[] args)
        {

            RecruitList RList = new RecruitList();
            Recruits Recruit;

            Recruit = new Recruits();
            Recruit.Name = "Phil Sims";
            Recruit.Position = "Quaterback";
            Recruit.School = "De Polly Prep";
            Recruit.State = "Maryland";
            Recruit.Age = 17;
            Recruit.StarRating = "****";
            Recruit.Speed = 4.8;
            Recruit.Weight = 189;
            RList.Add(Recruit);

            Recruit = new Recruits();
            Recruit.Name = "Chris P Bacon";
            Recruit.Position = "Runningback";
            Recruit.State = "Texas";
            Recruit.School = "Valley High";
            Recruit.Age = 16;
            Recruit.StarRating = "**";
            Recruit.Speed = 4.6;
            Recruit.Weight = 200;
            RList.Add(Recruit);

            Recruit = new Recruits();
            Recruit.Name = "Jojo Smith";
            Recruit.Position = "Wide Receiver";
            Recruit.State = "Texas";
            Recruit.School = "Riverside";
            Recruit.Age = 17;
            Recruit.StarRating = "*****";
            Recruit.Speed = 4.4;
            Recruit.Weight = 185;
            RList.Add(Recruit);

            Recruit = new Recruits();
            Recruit.Name = "Josh Moses";
            Recruit.Position = "Offensive Tackle";
            Recruit.State = "Massachusetts";
            Recruit.School = "Notre Dame Prep";
            Recruit.Age = 18;
            Recruit.StarRating = "***";
            Recruit.Speed = 5.3;
            Recruit.Weight = 280;
            RList.Add(Recruit);

            Recruit = new Recruits();
            Recruit.Name = "Evan Williams";
            Recruit.Position = "Defensive End";
            Recruit.State = "Florida";
            Recruit.School = "Modern Day Saints";
            Recruit.Age = 17;
            Recruit.StarRating = "****";
            Recruit.Speed = 4.7;
            Recruit.Weight = 245;
            RList.Add(Recruit);

            Recruit = new Recruits();
            Recruit.Name = "Maxwell Richards";
            Recruit.Position = "Offensive Guard";
            Recruit.State = "California";
            Recruit.School = "Riverside High";
            Recruit.Age = 18;
            Recruit.StarRating = "***";
            Recruit.Speed = 5.1;
            Recruit.Weight = 295;
            RList.Add(Recruit);

            Recruit = new Recruits();
            Recruit.Name = "Shane Ethan";
            Recruit.Position = "Wide Receiver";
            Recruit.State = "Oklahoma";
            Recruit.School = "St. Williams";
            Recruit.Age = 18;
            Recruit.StarRating = "****";
            Recruit.Speed = 4.5;
            Recruit.Weight = 295;
            RList.Add(Recruit);

            Recruit = new Recruits();
            Recruit.Name = "Steve Riddle";
            Recruit.Position = "Punter";
            Recruit.State = "Nevada";
            Recruit.School = "Regal High";
            Recruit.Age = 17;
            Recruit.StarRating = "**";
            Recruit.Speed = 4.7;
            Recruit.Weight = 169;
            RList.Add(Recruit);


            Console.WriteLine("--->> 2018- 2019 Recruitment List <<---\n\n");
            Console.WriteLine("Number of Recruits: {0}", RList.Count);

            for (int i = 0; i < RList.Count; i++)
            {
                Recruits info = RList.Get(i);
                Console.WriteLine("\nPlayer Info ");
                Console.WriteLine("Name: {0}", info.Name);
                Console.WriteLine("Position: {0}", info.Position);
                Console.WriteLine("State: {0}", info.State);
                Console.WriteLine("School: {0}", info.School);
                Console.WriteLine("Age: {0}", info.Age);
                Console.WriteLine("StarRating: {0}", info.Speed);
                Console.WriteLine("Weight: {0}", info.Weight);
               

            }

        }
    }
}
