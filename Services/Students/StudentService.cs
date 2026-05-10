// ---------------------------------------------------------------
// Copyright (c) Azimuth. All rights reserved.
// ---------------------------------------------------------------

using System.Threading.Tasks;
using Azimuth.Brokers.StudentMessages;
using Azimuth.Models.Students;

namespace Azimuth.Services.Students
{
    internal class StudentService : IStudentService
    {
        private readonly IStudentMessageBroker studentMessageBroker;

        public StudentService(IStudentMessageBroker studentMessageBroker) =>
            this.studentMessageBroker = studentMessageBroker;

        public async ValueTask AddStudentEvent(Student student) =>
            await this.studentMessageBroker.PublicAsync(student);
    }
}
