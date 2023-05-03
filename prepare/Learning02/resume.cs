using System;
using System.Collections;
using System.Collections.Generic;
namespace Learning02
{

    public class Resume{
       public List<Job> _jobs = new List<Job>();
       public string _name;
        public Resume(){
        }
        public void Display(){
            Console.WriteLine(_name);
            foreach (Job job in _jobs){
                job.Display();
            }
            
        }
    }
}