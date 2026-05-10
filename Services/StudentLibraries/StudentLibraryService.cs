// ---------------------------------------------------------------
// Copyright (c) Azimuth. All rights reserved.
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Azimuth.Brokers.StudentMessages;
using Azimuth.Models.Students;

namespace Azimuth.Services.StudentLibraries
{
    internal partial class StudentLibraryService : IStudentLibraryService
    {
        private readonly IStudentMessageBroker studentMessageBroker;

        public StudentLibraryService(IStudentMessageBroker studentMessageBroker) =>
            this.studentMessageBroker = studentMessageBroker;

        public void SubscribeToStudentEvent() =>
            this.studentMessageBroker.Subscribe(CreateStudentLibraryCardAsync);

        private async ValueTask<Student> CreateStudentLibraryCardAsync(Student student)
        {
            Console.WriteLine(value: $"Student {student.Name} Library Card was created.");

            return student;
        }
    }
}
