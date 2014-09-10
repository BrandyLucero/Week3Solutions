using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    enum Priority
    {
        Critical,
        HighImportance,
        NonCritical
    }
    class ticket
    {
        public string ClientName {get; set;}
        public string Description {get;set;}
        public Priority Priority {get; set;}
        public bool Resolved { get; set; }
        public DateTime DateEntered { get; set;}
        public DateTime DateResolved { get; set; }
        

        //step 2
        public ticket(string clientName, string description, Priority priority)
        {
            //
            this.ClientName = clientName;
            this.Description = description;
            this.Priority = priority;
            this.Resolved = false;
            this.DateEntered = DateTime.Now;

        }
        //step 3 methods AND FUNCTIONS
        public void ResolvedTicket()
        {
            this.Resolved = true;
            this.DateResolved = DateTime.Now;
        }
        public string GetTicketInfo()
        {
            return this.ClientName + " - " + this.Description + " - " + this.Priority + "\nResolved: " + this.Resolved;

        }
    }
}
