﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_11._30._2020
{
     class Faculty
    {
        
        public string Name { get; set; }
        public string Id { get; set; }
        public Faculty() { }
        public Faculty(string Name, string Id)
        {
           this.Name = Name;
            this.Id = Id;
        }
        public void Show()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
        }
    }
}
