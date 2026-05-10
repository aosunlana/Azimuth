// ---------------------------------------------------------------
// Copyright (c) Azimuth. All rights reserved.
// ---------------------------------------------------------------

using System.Threading.Tasks;
using Azimuth.Brokers.StudentMessages;
using Azimuth.Models.Students;
using Azimuth.Services.StudentLibraries;
using Azimuth.Services.Students;

namespace Azimuth
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            IStudentMessageBroker studentMessageBroker = new StudentMessageBroker();
            IStudentService studentService = new StudentService(studentMessageBroker);
            IStudentLibraryService studentLibraryService = new StudentLibraryService(studentMessageBroker);

            studentLibraryService.SubscribeToStudentEvent();

            await studentService.AddStudentEvent(
                student: new Student
                {
                    Name = "Abdulsamad"
                });

            await studentService.AddStudentEvent(
                student: new Student
                {
                    Name = "Zafar"
                });

            await studentService.AddStudentEvent(
                student: new Student
                {
                    Name = "Hassan"
                });
        }
    }
}
