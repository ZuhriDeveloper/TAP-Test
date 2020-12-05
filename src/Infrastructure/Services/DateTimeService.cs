using TAP_TEST.Application.Common.Interfaces;
using System;

namespace TAP_TEST.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
