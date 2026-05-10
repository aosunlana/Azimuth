// ---------------------------------------------------------------
// Copyright (c) Azimuth. All rights reserved.
// ---------------------------------------------------------------

using System.Threading.Tasks;
using Azimuth.Models.Students;

namespace Azimuth.Brokers.StudentMessages
{
    public partial interface IStudentMessageBroker
    {
        public delegate ValueTask<Student> OnStudentMessage(Student student);
    }
}
