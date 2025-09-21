using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Kitchen Porter";
        job1._company = "Bakers inn";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Shift Manager";
        job2._company = "Bakers inn";
        job2._startYear = 2018;
        job2._endYear = 2021;

        Job job3 = new Job();
        job3._jobTitle = "Shift Manager";
        job3._company = "Fish inn Simbisa";
        job3._startYear = 2022;
        job3._endYear = 2025;

        Job job4 = new Job();
        job4._jobTitle = "Junior Programmer";
        job4._company = "Econet-Dream Job";
        job4._startYear = 2025;
        job4._endYear = 2027;

        Resume myResume = new Resume();
        myResume._name = "Dylan Magumura";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume._jobs.Add(job4);

        
        myResume.Display();

       
    }
}
