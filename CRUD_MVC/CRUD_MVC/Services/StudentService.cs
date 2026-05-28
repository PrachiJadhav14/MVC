using System;
using System.Collections.Generic;

public class StudentService
{
    List<Student> list = new List<Student>();

    // ADD
    public void Add(Student s)
    {
        list.Add(s);
        Console.WriteLine("Student Added!");
    }

    // SHOW
    public void Show()
    {
        Console.WriteLine("\n--- Student List ---");

        foreach (var item in list)
        {
            Console.WriteLine(item.Id + " | " + item.Name + " | " + item.City);
        }
    }

    // UPDATE
    public void Update(Student s)
    {
        bool found = false;

        foreach (var item in list)
        {
            if (item.Id == s.Id)
            {
                item.Name = s.Name;
                item.City = s.City;
                found = true;

                Console.WriteLine("Updated Successfully!");
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Student Not Found!");
        }
    }

    // DELETE
    public void Delete(int id)
    {
        bool removed = false;

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Id == id)
            {
                list.RemoveAt(i);
                removed = true;

                Console.WriteLine("Deleted Successfully!");
                break;
            }
        }

        if (!removed)
        {
            Console.WriteLine("Student Not Found!");
        }
    }
}