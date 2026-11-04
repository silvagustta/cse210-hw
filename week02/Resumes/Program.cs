using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Front-end Senior";
        job1._company = "Apple";
        job1._starYear = 2017;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._starYear = 2025;
        job2._endYear = 2026;

        Resume myResume = new Resume();
        myResume._name = "John Marston";
        
        myResume._Job.Add(job1);
        myResume._Job.Add(job2);

        myResume.Display();
    }
}