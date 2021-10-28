using ListAssignmentP.EmployeeContact;
using System.Collections.Generic;
using System;
namespace ListAssignmentP.ganesh
{
    public class ContactList
    {
        List<Contact> list;
        public ContactList()
        {
            list = new List<Contact>();
        }
        public List<Contact> AddContact()
        {
            list.Add(new Contact{
                Eid=101,
                cName="Ganesh",
                cMail="Ganesh747@gmail.com"
            });
            list.Add(new Contact{
                Eid=102,
                cName="Nikhil",
                cMail="Nikhil@gmail.com"
            });
            list.Add(new Contact{
                Eid=103,
                cName="Areeb",
                cMail="Areeb@gmail.com"
            });
            list.Add(new Contact{
                Eid=104,
                cName="Karan",
                cMail="Karan@gmail.com"
            });
            return list;
        }
        public void updateContact()
        {
            int target = 2;
            list[target].cName="Shubham";
            list[target].cMail="Shubham@gmail.com";
            Console.WriteLine("Record Updated!");
        }
        public void deleteContact()
        {
            int target =3;
            list.RemoveAt(target);
            Console.WriteLine("Record Deleted!");
        }
        public void searchContact()
        {
                 int target = 1;
                list.FindIndex(employee =>employee.Eid ==target);
                Console.WriteLine("Found");
                Console.WriteLine("Name => "+list[target].cName+"\nEmail => "+list[target].cMail);
        }
    }
}