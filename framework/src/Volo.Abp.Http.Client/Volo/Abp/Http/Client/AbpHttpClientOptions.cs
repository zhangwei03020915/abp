using System;
using System.Collections.Generic;
using System.Net.Http;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Client.Proxying;

namespace Volo.Abp.Http.Client;

public class AbpHttpClientOptions
{
    public Dictionary<Type, HttpClientProxyConfig> HttpClientProxies { get; set; }

    public Dictionary<string, Action<HttpClientProxyConfig, ClientProxyRequestContext, HttpClient>> ProxyHttpClientPreSendActions { get; }

    public AbpHttpClientOptions()
    {
        HttpClientProxies = new Dictionary<Type, HttpClientProxyConfig>();
        ProxyHttpClientPreSendActions = new Dictionary<string, Action<HttpClientProxyConfig, ClientProxyRequestContext, HttpClient>>();
    }
}
