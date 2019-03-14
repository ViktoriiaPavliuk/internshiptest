using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution
{
    public class University
    {
        public string UniversityName { get; set; }

        private List<Student> _students = new List<Student>();

        public University(string name)
        {
            UniversityName = name;
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void AddStudents(List<Student> students)
        {
            _students.AddRange(students);
        }

        public List<Student> GetStudents()
        {
            return _students;
        }
    }
}
