using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Students.Models
{
    public class Repository
    {
        private static Dictionary<string, Student> responses;
        static Repository()
        {
            responses = new Dictionary<string, Student>();
            responses.Add("Trio A", new Student
            {
                NIM = 1,
                Name = "Trio",
                Alamat = "trio@mail.com",
                umur = 27
            });
            responses.Add("Ucu", new Student
            {
                NIM = 2,
                Name = "Ucu",
                Alamat = "ucu@mail.com",
                umur = 27
            });
            responses.Add("sofi", new Student
            {
                NIM = 3,
                Name = "sofi",
                Alamat = "sofi@mail.com",
                umur = 27
            });
            responses.Add("dwi", new Student
            {
                NIM = 3,
                Name = "dwi",
                Alamat = "dwi@mail.com",
                umur = 27
            });
        }
        public static void Add(Student newStudent)
        {
            string key = newStudent.Name.ToLowerInvariant();
            if (responses.ContainsKey(key))
            {
                responses[key] = newStudent;
            }
            else {
                responses.Add(key, newStudent);
            }
        }
        public static IEnumerable<Student> Responses
        {
            get { return responses.Values; }
        }
    }
}