using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Soldier
    {
        public string FIO {  get; set; }
        public string ValidityCategory { get; set; }
        public string MilitaryBranch { get; set; }
        public string Address { get; set; }
        public string PassportNumber { get; set; }
        public string PassportSeries { get; set; }
        public Soldier(string FIO, string validityCategory, string militaryBranch, string address, string passportNumber, string passportSeries)
        {
            this.FIO = FIO;
            this.ValidityCategory = validityCategory;
            this.MilitaryBranch = militaryBranch;
            this.Address = address;
            this.PassportNumber = passportNumber;
            this.PassportSeries = passportSeries;
        }
    }
}
