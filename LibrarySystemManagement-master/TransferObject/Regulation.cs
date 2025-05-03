using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Regulation
    {
        // Fields
        private int regulationID;
        private string description;
        private int MaxBorrowDays;
        private int finePerDay;
        private int MaxBooksAllowed;

        // Default constructor
        public Regulation()
        {
        }

        // Constructor with parameters
        public Regulation(int re_Id, string description, int maxBookDays, int finePerDays, int maxBookAllow)
        {
            this.regulationID = re_Id;
            this.Description = description;
            this.MaxBookDays = maxBookDays;
            this.finePerDay = finePerDays;
            this.MaxBooksAllowed = maxBookAllow;
        }

        // Properties (Getters and Setters)
        public int RegulationID
        {
            get { return regulationID ; }
            set { regulationID = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int MaxBookDays
        {
            get { return MaxBorrowDays; }
            set { MaxBorrowDays = value; }
        }

        public int FinePerDay
        {
            get { return finePerDay; }
            set { finePerDay = value; }
        }

        public int MaxBooksAllow
        {
            get { return MaxBooksAllowed; }
            set { MaxBooksAllowed = value; }
        }
    }

}
