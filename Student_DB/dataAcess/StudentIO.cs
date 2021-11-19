using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Student_DB.business;

namespace Student_DB.dataAcess
{
  
   public static class StudentIO
    {
      
        private static string filepath = Application.StartupPath + @"\Students.dat";
        private static string filetemp = Application.StartupPath + @"\Temp.dat";
        public static void SaveRecord(Student student)
        {

            StreamWriter streamWriter = new StreamWriter(filepath, true);
            streamWriter.WriteLine(student.Stusentid + "," + student.Name + ","
                + student.Cours + "," + student.Fee);
            streamWriter.Close();
            MessageBox.Show("Student data has been saved");
        }
        public static void ListStudent(ListView listViewStudent)//for adding in DB
        {
            StreamReader streamReader = new StreamReader(filepath);
            listViewStudent.Items.Clear();
            string line = streamReader.ReadLine();
            while(line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                item.SubItems.Add(fields[3]);
                listViewStudent.Items.Add(item);
                line = streamReader.ReadLine();
            }
            streamReader.Close();
        }
        public static List<Student> ListStudent()
        {
            List<Student> listc = new List<Student>();
            StreamReader streamReader = new StreamReader(filepath);
            string line = streamReader.ReadLine();
            while(line != null)
            {
                string[] fields = line.Split(',');
                Student student = new Student();
                student.Stusentid = Convert.ToInt32(fields[0]);
                student.Name = fields[1];
                student.Cours = fields[2];
                student.Fee = Convert.ToInt32(fields[3]);
                listc.Add(student);
                line = streamReader.ReadLine();


            }
            streamReader.Close();

            return listc;
        }
        public static Student Search(int studentID)
        {
            Student student = new Student();
            StreamReader streamReader = new StreamReader(filepath);
            string line = streamReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                if(studentID == Convert.ToInt32(fields[0]))
                {
                    student.Stusentid = Convert.ToInt32(fields[0]);
                    student.Name = fields[1];
                    student.Cours = fields[2];
                    student.Fee = Convert.ToInt32(fields[3]);
                    return student;
                }
                line = streamReader.ReadLine();

            }
            streamReader.Close();
                return null;
        }
        public static Student Search(string Name)
        {
            Student student = new Student();
            StreamReader streamReader = new StreamReader(filepath);
            string line = streamReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                if (Name == fields[1])
                {
                    student.Stusentid = Convert.ToInt32(fields[0]);
                    student.Name = fields[1];
                    student.Cours = fields[2];
                    student.Fee = Convert.ToInt32(fields[3]);
                    return student;
                }
                line = streamReader.ReadLine();

            }
            streamReader.Close();

                return null;
        }

        
        public static void Delete(int studentID)
        {
            StreamReader streamReader = new StreamReader(filepath);
            StreamWriter streamWriter = new StreamWriter(filetemp);
            string line = streamReader.ReadLine();
            while(line != null)
            {
                string[] fields = line.Split(',');
                if (studentID != Convert.ToInt32(fields[0]))
                { 
                streamWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3]);
                    }
                    line = streamReader.ReadLine();
            }
            streamReader.Close();
            streamWriter.Close();
            File.Delete(filepath);
            File.Move(filetemp, filepath);
           
        }
        public static void UpDate(Student student)
        {
            StreamReader streamReader = new StreamReader(filepath);
            StreamWriter streamWriter = new StreamWriter(filetemp);
            string line = streamReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                if (Convert.ToInt32(fields[0]) != student.Stusentid )
                {
                    streamWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3]);
                }
                line = streamReader.ReadLine();
            }
            streamReader.Close();
            streamWriter.Close();
            File.Delete(filepath);
            File.Move(filetemp, filepath);

        }



    }
    
}
