using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1() 
        { 
            Form1.textBox1.Text = "Коваленко Владислав Герасимович";
            Form1.textBox2.Text = "А";
            Form1.textBox3.Text = "Инженерные";
            Form1.textBox4.Text = "пос. Моревка";
            Form1.textBox5.Text = "4223";
            Form1.textBox6.Text = "232323";
        }
        [TestMethod]
        public void TestMethod1()
        {
            button1_Click();
            Assert.IsTrue(Form1.checkedListBox1.Length == 1);

        }
    }
}
