using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2015;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Professor";
        job2._company = "Brigham Young University - Idaho";
        job2._startYear = 2020;
        job2._endYear = 2023;

        // job1.Display();
        // job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Joyce Jensen";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}