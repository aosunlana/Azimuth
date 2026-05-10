// ---------------------------------------------------------------
// Copyright (c) Azimuth. All rights reserved.
// ---------------------------------------------------------------

using System.Threading.Tasks;
using Azimuth.Models.Students;

namespace Azimuth.Brokers.StudentMessages
{
    public partial interface IStudentMessageBroker
    {
        void Subscribe(OnStudentMessage onStudentMessage);
        ValueTask<Student> PublicAsync(Student student);
    }
}
