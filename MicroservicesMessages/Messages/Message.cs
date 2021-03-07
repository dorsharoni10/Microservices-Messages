﻿using System;

namespace Message
{
    public class Messages
    {

        public Message(string i_Name, DateTime i_Date, int i_Age, string i_Job)
        {
            this.Name = i_Name;
            this.Date = i_Date;
            this.Age = i_Age;
            this.Job = i_Job;
        }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public int Age { get; set; }

        public string Job { get; set; }
    }
}

