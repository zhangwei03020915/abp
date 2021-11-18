﻿namespace Volo.Abp.AspNetCore.ExceptionHandling
{
    public class AbpExceptionHandlingOptions
    {
        public bool SendExceptionsDetailsToClients { get; set; } = false;

        public bool SendStackTraceToClients { get; set; } = true;
    }
}
