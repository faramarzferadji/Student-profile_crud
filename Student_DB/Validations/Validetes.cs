using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_DB.business;
using Student_DB.dataAcess;
using Student_DB.GUI;
namespace Student_DB.Validations
{
    public class Validetes
    {
        public static bool IsValidID(string input)
        {
            int tempID;
            if(input.Length !=4 )
            {
                MessageBox.Show("Invalid ID, id has to 4 digites");
                return false;
            }
            return true;
        }
      


        public static bool IsUnique(List<Student> listc, int id)
        {
            foreach(Student student in listc)
            {
                if(student.Stusentid == id)
                {
                    MessageBox.Show("ID has to be unique !");
                    return false;
                }
            }
            return true;
        }
        public static bool IsvalidName(TextBox text)
        {
            for(int i=0; i<text.TextLength; i++)
            {
                if (char.IsDigit(text.Text, i) || (char.IsWhiteSpace(text.Text, i)))
                {
                    MessageBox.Show("Invalid Name, Please enter the valid name");
                    text.Clear();
                    text.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}
