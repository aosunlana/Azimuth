// ---------------------------------------------------------------
// Copyright (c) Azimuth. All rights reserved.
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Azimuth.Models.Students;
using static Azimuth.Brokers.StudentMessages.IStudentMessageBroker;

namespace Azimuth.Brokers.StudentMessages
{
    internal partial class StudentMessageBroker : IStudentMessageBroker
    {
        private OnStudentMessage onStudentMessageHandler;

        private event OnStudentMessage OnStudentMessage
        {
            add
            {
                Console.WriteLine(value: $"{value} subscribed to this message broker");
                this.onStudentMessageHandler += value;
            }

            remove
            {
                Console.WriteLine(value: $"{value} unsubscribed from this message broker");
                this.onStudentMessageHandler -= value;
            }
        }

        public async ValueTask<Student> PublicAsync(Student student) =>
            await this.onStudentMessageHandler.Invoke(student);

        public void Subscribe(OnStudentMessage onStudentMessage) =>
            this.OnStudentMessage += onStudentMessage;
    }
}
