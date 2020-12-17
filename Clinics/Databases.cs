using System;
using System.Collections.Generic;
using System.Text;

namespace Databases
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FIO { get; set; }
        public DocType DocType { get; set; }
        public string DocCredentials { get; set; }
        public string PhoneNumber { get; set; }
    }

    public enum DocType
    {
        Passport,
        BirthDoc,
    }

    public class Request
    {
        public Guid Id { get; set; } 
        public int VisistDateId { get; set; }
        public Guid UserId { get; set; }
    }

    public class Clinic
    {
        public int Id { get; set; }
        public string Address { get; set; }
    }

    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> ClinicIds { get; set; }
    }

    public class VisitDate
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int ClinicId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }

    public class Cheque
    {
        public Guid Id { get; set; }
        public Guid RequestId { get; set; }
    }

    public static class Database
    {
        public static List<User> Users { get; set; } = new List<User>
        {
            new User
            {
                Id = Guid.Parse("04cca6b9-0914-4f67-822d-c1b165f57043"),
                Username = "user1",
                Password = "password1",
                FIO = "Иванов Иван Иванович",
                DocType = DocType.Passport,
                DocCredentials = "1234-567891",
                PhoneNumber = "89123456789",
            },
        };

        public static List<Request> Requests { get; set; } = new List<Request>();

        public static List<Clinic> Clinics { get; set; } = new List<Clinic>
        { 
            new Clinic 
            {
                Id = 0,
                Address = "Уфа, ул. Кутузова, д. 3",
            },
            new Clinic
            {
                Id = 1,
                Address = "Уфа, ул. Красинская, д. 6",
            },
        };

        public static List<Service> Services { get; set; } = new List<Service>
        {
            new Service
            {
                Id = 0,
                Name = "МРТ",
                ClinicIds = new List<int>
                {
                    0,
                }
            },
            new Service
            {
                Id = 1,
                Name = "ФГДС",
                ClinicIds = new List<int>
                {
                    0,
                    1,
                }
            }
        };

        public static List<VisitDate> VisitDates { get; set; } = new List<VisitDate>
        {
            new VisitDate
            {
                Id = 0,
                ServiceId = 0,
                ClinicId = 0,
                Date = new DateTime(2021, 12, 1),
                Price = 1500M,
            },
            new VisitDate
            {
                Id = 1,
                ServiceId = 0,
                ClinicId = 0,
                Date = new DateTime(2021, 12, 2),
                Price = 1600M,
            },
            new VisitDate
            {
                Id = 2,
                ServiceId = 1,
                ClinicId = 0,
                Date = new DateTime(2021, 12, 3),
                Price = 1699M,
            },
            new VisitDate
            {
                Id = 3,
                ServiceId = 1,
                ClinicId = 1,
                Date = new DateTime(2021, 12, 3),
                Price = 1599M,
            },
        };

        public static List<Cheque> Cheques { get; set; } = new List<Cheque>();
    }
}
