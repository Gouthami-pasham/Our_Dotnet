﻿using dotnetproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetproject.Data
{
    public static class DbInitializer
    {
        //private static object studentterms;

        public static void Initialize(ApplicationDbContext context)
        {
          
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degreess already exist");
            }
            else
            {
                
                var degrees = new Degree[] {
                     new Degree{DegreeID =1,DegreeAbbrev = "ACS+2",DegreeName = "MsACS+2",NumberOFTerms = 5},
                     new Degree{DegreeID =2,DegreeAbbrev = "ACS+DB",DegreeName = "MsACS+DB",NumberOFTerms = 5},
                      new Degree{DegreeID =3,DegreeAbbrev = "ACS+NF",DegreeName = "MsACS+NF",NumberOFTerms = 5},
                       new Degree{DegreeID =4,DegreeAbbrev = "ACS",DegreeName = "MsACS",NumberOFTerms = 5}
                };
                Console.WriteLine($"Inserted{degrees.Length} new students.");
                foreach (Degree s in degrees)
                {
                    context.Degrees.Add(s);
                }
                context.SaveChanges();
            }

            if (context.Credits.Any())
            {
                Console.WriteLine("Credits already exist");
            }
            else
            {
                var credits = new Credit[] {
                     new Credit{CreditID =1,CreditAbbrev = "NF",CreditName = "NetworkFundamentals",IsSummer = 0,IsSpring = 1, IsFall = 1},
                     new Credit{CreditID =2,CreditAbbrev = "542",CreditName = "OOPSwithJAVA",IsSummer = 0,IsSpring = 1, IsFall = 1}
                };
                Console.WriteLine($"Inserted{credits.Length} new students.");
                foreach (Credit s in credits)
                {
                    context.Credits.Add(s);
                }
                context.SaveChanges();
            }

            if (context.DegreeCredit.Any())
            {
                Console.WriteLine("Degreess already exist");
            }
            else
            {
                var DegreeCredits = new DegreeCredit[] {
                new DegreeCredit { DegreeCreditID = 1, DegreeID = 1, CreditID = 460 },
new DegreeCredit { DegreeCreditID = 2, DegreeID = 1, CreditID = 356 },
new DegreeCredit { DegreeCreditID = 3, DegreeID = 1, CreditID = 542 },
new DegreeCredit { DegreeCreditID = 4, DegreeID = 1, CreditID = 563 },
new DegreeCredit { DegreeCreditID = 5, DegreeID = 1, CreditID = 560 },
new DegreeCredit { DegreeCreditID = 6, DegreeID = 1, CreditID = 664 },
new DegreeCredit { DegreeCreditID = 7, DegreeID = 1, CreditID = 618 },
new DegreeCredit { DegreeCreditID = 8, DegreeID = 1, CreditID = 555 },
new DegreeCredit { DegreeCreditID = 9, DegreeID = 1, CreditID = 691 },
new DegreeCredit { DegreeCreditID = 10, DegreeID = 1, CreditID = 692 },
new DegreeCredit { DegreeCreditID = 11, DegreeID = 1, CreditID = 6 },
new DegreeCredit { DegreeCreditID = 12, DegreeID = 1, CreditID = 10 },
new DegreeCredit { DegreeCreditID = 13, DegreeID = 1, CreditID = 20 },
new DegreeCredit { DegreeCreditID = 14, DegreeID = 2, CreditID = 460 },
new DegreeCredit { DegreeCreditID = 15, DegreeID = 2, CreditID = 542 },
new DegreeCredit { DegreeCreditID = 16, DegreeID = 2, CreditID = 563 },
new DegreeCredit { DegreeCreditID = 17, DegreeID = 2, CreditID = 560 },
new DegreeCredit { DegreeCreditID = 18, DegreeID = 2, CreditID = 664 },
new DegreeCredit { DegreeCreditID = 19, DegreeID = 2, CreditID = 618 },
new DegreeCredit { DegreeCreditID = 20, DegreeID = 2, CreditID = 555 },
new DegreeCredit { DegreeCreditID = 21, DegreeID = 2, CreditID = 691 },
new DegreeCredit { DegreeCreditID = 22, DegreeID = 2, CreditID = 692 },
new DegreeCredit { DegreeCreditID = 23, DegreeID = 2, CreditID = 6 },
new DegreeCredit { DegreeCreditID = 24, DegreeID = 2, CreditID = 10 },
new DegreeCredit { DegreeCreditID = 25, DegreeID = 2, CreditID = 20 },
new DegreeCredit { DegreeCreditID = 26, DegreeID = 3, CreditID = 356 },
new DegreeCredit { DegreeCreditID = 27, DegreeID = 3, CreditID = 542 },
new DegreeCredit { DegreeCreditID = 28, DegreeID = 3, CreditID = 563 },
new DegreeCredit { DegreeCreditID = 29, DegreeID = 3, CreditID = 560 },
new DegreeCredit { DegreeCreditID = 30, DegreeID = 3, CreditID = 664 },
new DegreeCredit { DegreeCreditID = 31, DegreeID = 3, CreditID = 618 },
new DegreeCredit { DegreeCreditID = 32, DegreeID = 3, CreditID = 555 },
new DegreeCredit { DegreeCreditID = 33, DegreeID = 3, CreditID = 691 },
new DegreeCredit { DegreeCreditID = 34, DegreeID = 3, CreditID = 692 },
new DegreeCredit { DegreeCreditID = 35, DegreeID = 3, CreditID = 6 },
new DegreeCredit { DegreeCreditID = 36, DegreeID = 3, CreditID = 10 },
new DegreeCredit { DegreeCreditID = 37, DegreeID = 3, CreditID = 20 },
new DegreeCredit { DegreeCreditID = 38, DegreeID = 4, CreditID = 542 },
new DegreeCredit { DegreeCreditID = 39, DegreeID = 4, CreditID = 563 },
new DegreeCredit { DegreeCreditID = 40, DegreeID = 4, CreditID = 560 },
new DegreeCredit { DegreeCreditID = 41, DegreeID = 4, CreditID = 664 },
new DegreeCredit { DegreeCreditID = 42, DegreeID = 4, CreditID = 618 },
new DegreeCredit { DegreeCreditID = 43, DegreeID = 4, CreditID = 555 },
new DegreeCredit { DegreeCreditID = 44, DegreeID = 4, CreditID = 691 },
new DegreeCredit { DegreeCreditID = 45, DegreeID = 4, CreditID = 692 },
new DegreeCredit { DegreeCreditID = 46, DegreeID = 4, CreditID = 6 },
new DegreeCredit { DegreeCreditID = 47, DegreeID = 4, CreditID = 10 },
new DegreeCredit { DegreeCreditID = 48, DegreeID = 4, CreditID = 20 },

};


                Console.WriteLine($"Inserted{DegreeCredits.Length} new students.");
                foreach (DegreeCredit De in DegreeCredits)
                {
                    context.DegreeCredit.Add(De);
                }
                context.SaveChanges();

            }

            if (context.Students.Any())
            {
                Console.WriteLine("Students already exist");
            }
            else
            {
                var students = new Student[] {
                    new Student{StudentID =1,LastName = "Singam",FirstName = "Poojitha",I919 = 919571721},
                    new Student{StudentID =2,LastName = "Konidela",FirstName = "RamCharan",I919 = 919571722},
                };
                Console.WriteLine($"Inserted{students.Length} new students.");
                foreach (Student s in students)
                {
                    context.Students.Add(s);
                }
                context.SaveChanges();
            }

            if (context.DegreePlans.Any())
            {
                Console.WriteLine("DegreePlans already exist");
            }
            else
            {
                var degreeplans = new DegreePlan[] {

                 new DegreePlan{DegreePlanID=7253,StudentID=533705,DegreePlanAbbrev="Super fast",DereePlanName="As fast as I can",DegreeID=3},
new DegreePlan{DegreePlanID=7254,StudentID=533705,DegreePlanAbbrev="slow And Easy",DereePlanName="Take a summer Off",DegreeID=3},
new DegreePlan{DegreePlanID=7255,StudentID=533491,DegreePlanAbbrev="Super fast",DereePlanName="As fast as I can",DegreeID=3},
new DegreePlan{DegreePlanID=7256,StudentID=533491,DegreePlanAbbrev="slow And Easy",DereePlanName="Take a summer Off",DegreeID=3},
new DegreePlan{DegreePlanID=7257,StudentID=533727,DegreePlanAbbrev="SuperFast",DereePlanName="As fast as I can",DegreeID=3},
new DegreePlan{DegreePlanID=7258,StudentID=533727,DegreePlanAbbrev="slow And Easy",DereePlanName="Take a summer Off",DegreeID=3},
new DegreePlan{DegreePlanID=7259,StudentID=533622,DegreePlanAbbrev="slow And Easy",DereePlanName="Take a summer Off",DegreeID=3},
new DegreePlan{DegreePlanID=7260,StudentID=533622,DegreePlanAbbrev="slow And Easy",DereePlanName="Take a summer Off",DegreeID=3},
new DegreePlan{DegreePlanID=7261,StudentID=533988,DegreePlanAbbrev="Super fast",DereePlanName="As fast as I can",DegreeID=3},
new DegreePlan{DegreePlanID=7262,StudentID=533988,DegreePlanAbbrev="slow And Easy",DereePlanName="Take a summer Off",DegreeID=3},


                };
                Console.WriteLine($"Inserted{degreeplans.Length} new students.");
                foreach (DegreePlan s in degreeplans)
                {
                    context.DegreePlans.Add(s);
                }
                context.SaveChanges();
            }

            if (context.Slots.Any())
            {
                Console.WriteLine("Slots already exist");
            }
            else
            {
                var slots = new Slot[] {
                    new Slot{SlotID =1,DegreePlanID =7255,Term=1,CreditID=356,Status='B'},
                    new Slot{SlotID =2,DegreePlanID =7255,Term=1,CreditID=542,Status='B'}
                };
                Console.WriteLine($"Inserted{slots.Length} new slots.");
                foreach (Slot s in slots)
                {
                    context.Slots.Add(s);
                }
                context.SaveChanges();
            }

            if (context.StudentTerms.Any())
            {
                Console.WriteLine("Degreess already exist");
            }
            else
            {
                var studentterms = new StudentTerm[] {
new StudentTerm{StudentTermID=1,DegreePlanId=7255,Term=1,TermAbbrev="F18",TermName="Fall2018"},
new StudentTerm{StudentTermID=2,DegreePlanId=7255,Term=2,TermAbbrev="S19",TermName="Spring2019"},
new StudentTerm{StudentTermID=3,DegreePlanId=7255,Term=3,TermAbbrev="Sum",TermName="Summer2019"},
new StudentTerm{StudentTermID=4,DegreePlanId=7255,Term=4,TermAbbrev="F19",TermName="Fall2019"},
new StudentTerm{StudentTermID=5,DegreePlanId=7256,Term=1,TermAbbrev="F18",TermName="Fall2018"},
new StudentTerm{StudentTermID=6,DegreePlanId=7256,Term=2,TermAbbrev="S19",TermName="Spring2019"},
new StudentTerm{StudentTermID=7,DegreePlanId=7256,Term=3,TermAbbrev="F19",TermName="Fall2019"},
new StudentTerm{StudentTermID=8,DegreePlanId=7256,Term=4,TermAbbrev="S20",TermName="Spring2020"},
new StudentTerm{StudentTermID=9,DegreePlanId=7261,Term=1,TermAbbrev="F19",TermName="Fall2019"},
new StudentTerm{StudentTermID=10,DegreePlanId=7261,Term=2,TermAbbrev="S20",TermName="SPRING2020"},
new StudentTerm{StudentTermID=11,DegreePlanId=7261,Term=3,TermAbbrev="SU20",TermName="SUMMER2020"},
new StudentTerm{StudentTermID=12,DegreePlanId=7261,Term=4,TermAbbrev="F20",TermName="Fall2020"},
new StudentTerm{StudentTermID=13,DegreePlanId=7262,Term=1,TermAbbrev="F19",TermName="FALL2019"},
new StudentTerm{StudentTermID=14,DegreePlanId=7262,Term=2,TermAbbrev="S20",TermName="SPRING2020"},
new StudentTerm{StudentTermID=15,DegreePlanId=7262,Term=3,TermAbbrev="SU20",TermName="SUMMER2020"},
new StudentTerm{StudentTermID=16,DegreePlanId=7262,Term=4,TermAbbrev="F20",TermName="FALL2020"},
new StudentTerm{StudentTermID=17,DegreePlanId=7262,Term=5,TermAbbrev="S21",TermName="SPRING2021"},
new StudentTerm{StudentTermID=18,DegreePlanId=7259,Term=1,TermAbbrev="F18",TermName="FALL2018"},
new StudentTerm{StudentTermID=19,DegreePlanId=7259,Term=2,TermAbbrev="S19",TermName="Spring2019"},
new StudentTerm{StudentTermID=20,DegreePlanId=7259,Term=3,TermAbbrev="Sum19",TermName="Summer2019"},
new StudentTerm{StudentTermID=21,DegreePlanId=7259,Term=4,TermAbbrev="F19",TermName="Fall2019"},
new StudentTerm{StudentTermID=22,DegreePlanId=7259,Term=5,TermAbbrev="S20",TermName="Spring2020"},
new StudentTerm{StudentTermID=23,DegreePlanId=7260,Term=1,TermAbbrev="F18",TermName="FALL2018"},
new StudentTerm{StudentTermID=24,DegreePlanId=7260,Term=2,TermAbbrev="S19",TermName="Spring2019"},
new StudentTerm{StudentTermID=25,DegreePlanId=7260,Term=3,TermAbbrev="F19",TermName="Fall2019"},
new StudentTerm{StudentTermID=26,DegreePlanId=7260,Term=4,TermAbbrev="S20",TermName="Spring2020"},
new StudentTerm{StudentTermID=27,DegreePlanId=7260,Term=5,TermAbbrev="Sum20",TermName="Summer2020"},
new StudentTerm{StudentTermID=28,DegreePlanId=7257,Term=1,TermAbbrev="F18",TermName="FALL2018"},
new StudentTerm{StudentTermID=29,DegreePlanId=7257,Term=2,TermAbbrev="S19",TermName="Spring2019"},
new StudentTerm{StudentTermID=30,DegreePlanId=7257,Term=3,TermAbbrev="Sum19",TermName="Summer2019"},
new StudentTerm{StudentTermID=31,DegreePlanId=7257,Term=4,TermAbbrev="F19",TermName="Fall2019"},
new StudentTerm{StudentTermID=32,DegreePlanId=7258,Term=1,TermAbbrev="F18",TermName="FALL2018"},
new StudentTerm{StudentTermID=33,DegreePlanId=7258,Term=2,TermAbbrev="S19",TermName="Spring2019"},
new StudentTerm{StudentTermID=34,DegreePlanId=7258,Term=3,TermAbbrev="F19",TermName="Fall2019"},
new StudentTerm{StudentTermID=35,DegreePlanId=7258,Term=4,TermAbbrev="S20",TermName="Spring2020"},
new StudentTerm{StudentTermID=36,DegreePlanId=7258,Term=5,TermAbbrev="Sum20",TermName="Summer2020"},
new StudentTerm{StudentTermID=37,DegreePlanId=7253,Term=1,TermAbbrev="F 2018",TermName="Fall 2018"},
new StudentTerm{StudentTermID=38,DegreePlanId=7253,Term=2,TermAbbrev="S19",TermName="Spring 2019"},
new StudentTerm{StudentTermID=39,DegreePlanId=7253,Term=3,TermAbbrev="Sum19",TermName="Summer 2019"},
new StudentTerm{StudentTermID=40,DegreePlanId=7253,Term=4,TermAbbrev="F19",TermName="Fall 2019"},
new StudentTerm{StudentTermID=41,DegreePlanId=7254,Term=1,TermAbbrev="S19",TermName="Spring 2019"},
new StudentTerm{StudentTermID=42,DegreePlanId=7254,Term=2,TermAbbrev="F19",TermName="Fall 2019"},
new StudentTerm{StudentTermID=43,DegreePlanId=7254,Term=3,TermAbbrev="S20",TermName="Spring 2020"},
new StudentTerm{StudentTermID=44,DegreePlanId=7254,Term=4,TermAbbrev="Sum20",TermName="Summer 2020"},
new StudentTerm{StudentTermID=45,DegreePlanId=7254,Term=5,TermAbbrev="F20",TermName="Fall 2020"},

                };
                Console.WriteLine($"Inserted{studentterms.Length} new students.");
                foreach (StudentTerm s in studentterms)
                {
                    context.StudentTerms.Add(s);
                }
                context.SaveChanges();
            }
        }
    }
}


        

    

