// Hometask 2.8

using Hometask_2._8.Context;
using Hometask_2._8.Entities;
using Hometask_2._8.Repository;
using System;


namespace App
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new ScheduleDbContext())
            {
                var repository = new GenericRepository<Client>(context);


                var person = new Client()
                {
                    FullName = "Jorja Smith",
                    Age = 25,
                    Gender = "Female",
                    Schedules = new List<Schedule>
                    {
                        new Schedule { Topic = "Work Meeting", Time = "09:30", Date = "09/07/2022"},
                        new Schedule { Topic = "Talking", Time = "12:10", Date = "09/07/2022"},
                        new Schedule { Topic = "English Practice", Time = "16:00", Date = "09/07/2022"},
                        new Schedule { Topic = "Family Call", Time = "20:00", Date = "09/07/2022"},
                    }
                };

                repository.Add(person);
            }
        }
    }
}