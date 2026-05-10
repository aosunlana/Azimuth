// ---------------------------------------------------------------
// Copyright (c) Azimuth. All rights reserved.
// ---------------------------------------------------------------

using System.Threading.Tasks;
using Azimuth.Models.Students;

namespace Azimuth.Services.Students
{
    public interface IStudentService
    {
        ValueTask AddStudentEvent(Student student);
    }
}
