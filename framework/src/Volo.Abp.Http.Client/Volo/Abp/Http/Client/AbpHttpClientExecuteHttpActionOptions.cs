using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Text;
using Volo.Abp.Http.Modeling;

namespace Volo.Abp.Http.Client;
public class AbpHttpClientExecuteHttpActionOptions
{
    public Action<ActionApiDescriptionModel, HttpClient>? ExecuteHttpAction{ get; set; }
}
