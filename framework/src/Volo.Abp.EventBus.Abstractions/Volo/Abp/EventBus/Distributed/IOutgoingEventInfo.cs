using System;
using Volo.Abp.Data;

namespace Volo.Abp.EventBus.Distributed;

public interface IOutgoingEventInfo : IHasExtraProperties
{
    public Guid Id { get; }

    public string EventName { get; }

    public byte[] EventData { get; }

    public DateTime CreationTime { get; }
}
