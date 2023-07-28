﻿using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Tracing;

namespace Volo.Abp.AspNetCore.Tracing;

public class AbpCorrelationIdMiddleware : IMiddleware, ITransientDependency
{
    private readonly AbpCorrelationIdOptions _options;
    private readonly ICorrelationIdProvider _correlationIdProvider;

    public AbpCorrelationIdMiddleware(IOptions<AbpCorrelationIdOptions> options,
        ICorrelationIdProvider correlationIdProvider)
    {
        _options = options.Value;
        _correlationIdProvider = correlationIdProvider;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var correlationId = _correlationIdProvider.Get();
        CheckAndSetCorrelationIdOnResponse(context, _options, correlationId);
        await next(context);
    }

    protected virtual void CheckAndSetCorrelationIdOnResponse(
        HttpContext httpContext,
        AbpCorrelationIdOptions options,
        string? correlationId)
    {
        httpContext.Response.OnStarting(() =>
        {
            if (options.SetResponseHeader && !httpContext.Response.Headers.ContainsKey(options.HttpHeaderName) && !string.IsNullOrWhiteSpace(correlationId))
            {
                httpContext.Response.Headers[options.HttpHeaderName] = correlationId;
            }

            return Task.CompletedTask;
        });
    }
}
