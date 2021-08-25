using System;
using System.Collections.Generic;

namespace Contact
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact[] contacts = new Contact[]
            {
                new Contact
                {
                    FirstName = "Петр",
                    LastName = "Савельев",
                    Phones = new List<string>
                    {
                        "+79042144491"
                    },
                    Email = "petersav@email.com"
                },
                new Contact
                {
                    FirstName = "Никита",
                    LastName = "",
                    Phones = new List<string>
                    {
                        "+79832456533"
                    },
                    Email = "",
                },
                new Contact
                {
                    FirstName = "Начальник",
                    LastName = "",
                    Phones = new List<string>
                    {
                        "+79245001020",
                        "2435064"
                    },
                    Email = "stepanovfedor1975@email.com"
                },
                new Contact
                {
                    FirstName = "Mama",
                    LastName="",
                    Phones=new List<string>
                    {
                        "+79864553219"
                    },
                    Email=""

                },
                new Contact
                {
                    FirstName = "Маша",
                    LastName="",
                    Phones=new List<string>
                    {
                        "+79022334355",
                        "5664321"
                    },
                    Email=""
                }


            };

        }

    }
}