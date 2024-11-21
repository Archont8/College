using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    internal class NullSurnameException : Exception
    {
        public NullSurnameException()
        {
            MessageBox.Show("Поле фамилии не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    internal class NullNameException : Exception
    {
        public NullNameException()
        {
            MessageBox.Show("Поле имени не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    internal class NullSeriesPassportException : Exception
    {
        public NullSeriesPassportException()
        {
            MessageBox.Show("Поле серии паспорта не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    internal class NullNumberPassportException : Exception
    {
        public NullNumberPassportException()
        {
            MessageBox.Show("Поле номера паспорта не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    internal class NullHoursException : Exception
    {
        public NullHoursException()
        {
            MessageBox.Show("Поле рабочих часов не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
