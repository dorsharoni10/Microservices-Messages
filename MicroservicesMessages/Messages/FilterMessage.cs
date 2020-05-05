using System;

namespace Messages
{
    public class FilterMessage
    {

        public FilterMessage(string i_Name, DateTime i_Date, string i_Job)
        {
            this.Name = i_Name;
            this.Date = i_Date;
            this.Job = i_Job;
        }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string Job { get; set; }
    }
}

