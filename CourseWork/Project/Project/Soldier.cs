using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Soldier
    {
        string FIO;
        string Address;
        char   ValidityCategory;
        string MilitaryBranch;
        string PassportNumber;
        string PassportSeries;
        public Soldier(string FIO, char ValidityCategory, string MilitaryBranch,
             string Address, string PassportNumber,
            string PassportSeries)
        {
            this.FIO = FIO;
            this.ValidityCategory = ValidityCategory;
            this.MilitaryBranch = MilitaryBranch;
            this.Address = Address;
            this.PassportNumber = PassportNumber;
            this.PassportSeries = PassportSeries;
        }

    }
}
