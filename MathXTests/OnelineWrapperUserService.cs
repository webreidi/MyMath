using System;
using Application.Providers;

namespace Application.Services
{
    public class OnelineWrapperUserService
    {
        public OnelineWrapperUserService(OnelineWrapperDateTimeProvider dateTimeProvider)
        {
            whatTime = dateTimeProvider.Now;
        }

        public DateTime whatTime { get; }
    }
}